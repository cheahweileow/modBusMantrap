using EasyModbus;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Lingkail.ModbusMantrap
{ 
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        private static string ipAddress="192.168.1.253";
        private static int portInput = 1030;
        private static ModbusClient modbusClient=new ModbusClient();
        private static bool coilsToSend;
        private static void Main()
        {
            Console.WriteLine("welcome to FSM");
            setupModbusController();
            //run the mantrapFSM
            mantrapFSM();
        }

        private static void setupModbusController()
        {
            modbusClient.IPAddress = ipAddress;
            modbusClient.Port = portInput;
                    //modbusClient.receiveDataChanged += new EasyModbus.ModbusClient.ReceiveDataChanged(UpdateReceiveData);
                    //modbusClient.sendDataChanged += new EasyModbus.ModbusClient.SendDataChanged(UpdateSendData);
                    //modbusClient.connectedChanged += new EasyModbus.ModbusClient.ConnectedChanged(UpdateConnectedChanged);
            modbusClient.Connect();
            coilsToSend = true; // init to true to turn on LED first round

            
        }
        private static void mantrapFSM()
        {
            for (int loopTwice = 0; loopTwice<2; loopTwice++)//loop twice to turn on then turn off LED
            {

                int numberOfValuesInput = 8; //we using an 8 input devices
                bool[] serverResponse = modbusClient.ReadCoils(0, numberOfValuesInput);
                bool[] inputResponse = modbusClient.ReadDiscreteInputs(0, numberOfValuesInput);
                for (int i = 0; i<numberOfValuesInput; i++)
                {
                    Console.WriteLine("output port "+i.ToString()+": "+serverResponse[i].ToString());
                }
                for (int i = 0; i<numberOfValuesInput; i++)
                {
                    Console.WriteLine("input x "+i.ToString()+": "+inputResponse[i].ToString());
                }
                for (int i = 0; i < 8; i++)
                {
                    modbusClient.WriteSingleCoil(i, coilsToSend);// index of port is zero based
                    Thread.Sleep(500);//a delay so that we can see the transition
                }

                if(coilsToSend==true)
                {
                    coilsToSend=false;
                }
                else
                {
                    coilsToSend=true;
                }
            }
        }
    }
}