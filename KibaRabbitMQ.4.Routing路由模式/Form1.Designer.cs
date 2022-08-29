namespace KibaRabbitMQ._4.Routing路由模式
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
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.rBoxReceive2 = new System.Windows.Forms.RichTextBox();
            this.rBoxReceive1 = new System.Windows.Forms.RichTextBox();
            this.rBoxSendMessage = new System.Windows.Forms.RichTextBox();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(691, 116);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(111, 31);
            this.btnReceiveMessage.TabIndex = 11;
            this.btnReceiveMessage.Text = "ReceiveMessage";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // rBoxReceive2
            // 
            this.rBoxReceive2.Location = new System.Drawing.Point(267, 164);
            this.rBoxReceive2.Name = "rBoxReceive2";
            this.rBoxReceive2.Size = new System.Drawing.Size(267, 280);
            this.rBoxReceive2.TabIndex = 9;
            this.rBoxReceive2.Text = "";
            // 
            // rBoxReceive1
            // 
            this.rBoxReceive1.Location = new System.Drawing.Point(5, 164);
            this.rBoxReceive1.Name = "rBoxReceive1";
            this.rBoxReceive1.Size = new System.Drawing.Size(256, 280);
            this.rBoxReceive1.TabIndex = 8;
            this.rBoxReceive1.Text = "";
            // 
            // rBoxSendMessage
            // 
            this.rBoxSendMessage.Location = new System.Drawing.Point(-6, 7);
            this.rBoxSendMessage.Name = "rBoxSendMessage";
            this.rBoxSendMessage.Size = new System.Drawing.Size(548, 140);
            this.rBoxSendMessage.TabIndex = 7;
            this.rBoxSendMessage.Text = "";
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Location = new System.Drawing.Point(560, 18);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(111, 31);
            this.BtnSendMessage.TabIndex = 6;
            this.BtnSendMessage.Text = "SendMessage";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.btnReceiveMessage);
            this.Controls.Add(this.rBoxReceive2);
            this.Controls.Add(this.rBoxReceive1);
            this.Controls.Add(this.rBoxSendMessage);
            this.Controls.Add(this.BtnSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReceiveMessage;
        private RichTextBox rBoxReceive2;
        private RichTextBox rBoxReceive1;
        private RichTextBox rBoxSendMessage;
        private Button BtnSendMessage;
    }
}