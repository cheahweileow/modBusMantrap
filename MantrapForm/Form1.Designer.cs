namespace MantrapForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1=new ListBox();
            buttonAddCheckPoint=new Button();
            buttonDeleteCheckPoint=new Button();
            buttonInitCheckPoints=new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled=true;
            listBox1.ItemHeight=32;
            listBox1.Items.AddRange(new object[] { "checkpoint1", "checkpoint2" });
            listBox1.Location=new Point(125, 207);
            listBox1.Name="listBox1";
            listBox1.Size=new Size(461, 260);
            listBox1.TabIndex=1;
            // 
            // buttonAddCheckPoint
            // 
            buttonAddCheckPoint.Location=new Point(608, 207);
            buttonAddCheckPoint.Name="buttonAddCheckPoint";
            buttonAddCheckPoint.Size=new Size(236, 71);
            buttonAddCheckPoint.TabIndex=2;
            buttonAddCheckPoint.Text="Add checkpoint";
            buttonAddCheckPoint.UseVisualStyleBackColor=true;
            // 
            // buttonDeleteCheckPoint
            // 
            buttonDeleteCheckPoint.Location=new Point(608, 305);
            buttonDeleteCheckPoint.Name="buttonDeleteCheckPoint";
            buttonDeleteCheckPoint.Size=new Size(236, 71);
            buttonDeleteCheckPoint.TabIndex=3;
            buttonDeleteCheckPoint.Text="Delete";
            buttonDeleteCheckPoint.UseVisualStyleBackColor=true;
            // 
            // buttonInitCheckPoints
            // 
            buttonInitCheckPoints.Location=new Point(621, 66);
            buttonInitCheckPoints.Name="buttonInitCheckPoints";
            buttonInitCheckPoints.Size=new Size(218, 74);
            buttonInitCheckPoints.TabIndex=4;
            buttonInitCheckPoints.Text="Init Checkpoints";
            buttonInitCheckPoints.UseVisualStyleBackColor=true;
            buttonInitCheckPoints.Click+=buttonInitCheckPoints_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(921, 647);
            Controls.Add(buttonInitCheckPoints);
            Controls.Add(buttonDeleteCheckPoint);
            Controls.Add(buttonAddCheckPoint);
            Controls.Add(listBox1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button buttonAddCheckPoint;
        private Button buttonDeleteCheckPoint;
        private Button buttonInitCheckPoints;
    }
}