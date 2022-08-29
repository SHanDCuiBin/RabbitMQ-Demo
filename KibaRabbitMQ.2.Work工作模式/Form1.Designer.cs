namespace KibaRabbitMQ._2.Work工作模式
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
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.rBoxSendMessage = new System.Windows.Forms.RichTextBox();
            this.rBoxReceive1 = new System.Windows.Forms.RichTextBox();
            this.rBoxReceive2 = new System.Windows.Forms.RichTextBox();
            this.rBoxReceive3 = new System.Windows.Forms.RichTextBox();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Location = new System.Drawing.Point(567, 12);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(111, 31);
            this.BtnSendMessage.TabIndex = 0;
            this.BtnSendMessage.Text = "SendMessage";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // rBoxSendMessage
            // 
            this.rBoxSendMessage.Location = new System.Drawing.Point(1, 1);
            this.rBoxSendMessage.Name = "rBoxSendMessage";
            this.rBoxSendMessage.Size = new System.Drawing.Size(548, 140);
            this.rBoxSendMessage.TabIndex = 1;
            this.rBoxSendMessage.Text = "";
            // 
            // rBoxReceive1
            // 
            this.rBoxReceive1.Location = new System.Drawing.Point(12, 158);
            this.rBoxReceive1.Name = "rBoxReceive1";
            this.rBoxReceive1.Size = new System.Drawing.Size(256, 280);
            this.rBoxReceive1.TabIndex = 2;
            this.rBoxReceive1.Text = "";
            // 
            // rBoxReceive2
            // 
            this.rBoxReceive2.Location = new System.Drawing.Point(274, 158);
            this.rBoxReceive2.Name = "rBoxReceive2";
            this.rBoxReceive2.Size = new System.Drawing.Size(267, 280);
            this.rBoxReceive2.TabIndex = 3;
            this.rBoxReceive2.Text = "";
            // 
            // rBoxReceive3
            // 
            this.rBoxReceive3.Location = new System.Drawing.Point(547, 158);
            this.rBoxReceive3.Name = "rBoxReceive3";
            this.rBoxReceive3.Size = new System.Drawing.Size(267, 280);
            this.rBoxReceive3.TabIndex = 4;
            this.rBoxReceive3.Text = "";
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(698, 110);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(111, 31);
            this.btnReceiveMessage.TabIndex = 5;
            this.btnReceiveMessage.Text = "ReceiveMessage";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.btnReceiveMessage);
            this.Controls.Add(this.rBoxReceive3);
            this.Controls.Add(this.rBoxReceive2);
            this.Controls.Add(this.rBoxReceive1);
            this.Controls.Add(this.rBoxSendMessage);
            this.Controls.Add(this.BtnSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnSendMessage;
        private RichTextBox rBoxSendMessage;
        private RichTextBox rBoxReceive1;
        private RichTextBox rBoxReceive2;
        private RichTextBox rBoxReceive3;
        private Button btnReceiveMessage;
    }
}