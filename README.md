# ModBus TCP via ZQWL IO Card



## Getting started

Default IP address is 192.168.1.253 port 1030

## Prerequisite

- [ ] [Lingkail](https://www.lingkail.biz.my)  

## ModBus 101
# What is Modbus TCP?
Modbus TCP encapsulates Modbus RTU request and response data packets in a TCP packet transmitted over standard Ethernet networks. The unit number is still included and its interpretation varies by application – the unit or slave address is not the primary means of addressing in TCP. The address of most importance here is the IP address, e.g. 192.168.1.100. The standard port for Modbus TCP is 502, but port number can often be reassigned if desired.

The checksum field normally found at the end of an RTU packet is omitted from the TCP packet. Checksum and error handling are handled by Ethernet in the case of Modbus TCP.

The TCP version of Modbus follows the OSI Network Reference Model. Modbus TCP defines the presentation and application layers in the OSI model.

Modbus TCP makes the definition of master and slave less obvious because Ethernet allows peer to peer communication. The definition of client and server are better known entities in Ethernet based networking. In this context, the slave becomes the server and the master becomes the client. There can be more than one client obtaining data from a server. In Modbus terms, this means there can be multiple masters as well as multiple slaves. Rather than defining master and slave on a physical device by device basis, it now becomes the system designer’s responsibility to create logical associations between master and slave functionality.

# What is Modbus ASCII?
Modbus ASCII is an older implementation that contains all of the elements of an RTU packet, but expressed entirely in printable ASCII characters. Modbus ASCII is considered deprecated, is rarely used any more, and is not included in the formal Modbus protocol specification.

# Review of Modbus Register Types
The types of registers referenced in Modbus devices include the following:
• Coil (Discrete Output)
• Discrete Input (or Status Input)
• Input Register
• Holding Register
Whether a particular device includes all of these register types is up to the manufacturer. It is very common to find all I/O mapped to holding registers only. Coils are 1-bit registers, are used to control discrete outputs, and may be read or written. Discrete Inputs are 1-bit registers used as inputs, and may only be read. Input registers are 16-bit registers used for input, and may only be read. Holding registers are the most universal 16-bit register, may be read or written, and may be used for a variety of things including inputs, outputs, configuration data, or any requirement for "holding" data.

Control Solutions gateways will support all register types when the gateway is the master, or when operating in direct mode (Babel Buster SP-GW). Control Solutions gateways that connect a non-Modbus device to a Modbus network will in some cases use only holding registers to represent the non-Modbus device data.

Most Control Solutions I/O devices use holding registers for all types of inputs and outputs. In most cases, the same I/O is accessible as other register types as well, with the I/O status or value being mirrored in multiple registers.

Review of Modbus Function Codes
Modbus protocol defines several function codes for accessing Modbus registers. There are four different data blocks defined by Modbus, and the addresses or register numbers in each of those overlap. Therefore, a complete definition of where to find a piece of data requires both the address (or register number) and function code (or register type).

The function codes most commonly recognized by Modbus devices are indicated in the table below. This is only a subset of the codes available - several of the codes have special applications that most often do not apply.

Modbus Function Codes 
Function Code	Register Type
1	Read Coil
2	Read Discrete Input
3	Read Holding Registers
4	Read Input Registers
5	Write Single Coil
6	Write Single Holding Register
15	Write Multiple Coils
16	Write Multiple Holding Registers

| Fucntion Code  | Register Type  |   
|----------------|----------------|
|                |                |
|                |                |
|                |                |
|                |                |
|                |                |
|                |                |
|                |                |
|                |                |
|                |                |
 

## About ModBus
Since the Address field is a signed 16-bit integer, the maximum positive value accepted by is 32767

However the  Address field is a Modbus offset value. When using a Modbus function code 3, 6, or 16, an address base of 40001 is assumed. The  Address field is an offset from this base.

Examples:
If an address of 40001 needs to be accessed, then a Address of 0 is used (40001 - 40001 base = offset address of 0)
If an address of 41031 needs to be accessed, then a Address of 1030 is used (41031 - 40001 base = offset address of 1030)
If the required OFFSET actually exceeds 32767, add 65536 to calculate the signed value of this address, and that value will be accepted as a signed 16 bit INT.

```

## Integrate with your tools

- EasyModbus is incompatible with .NET 7

## Authors and acknowledgment


## License
For open source projects, say how it is licensed.

## Project status
Active as of 1st August 2023