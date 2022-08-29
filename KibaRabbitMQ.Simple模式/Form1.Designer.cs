namespace KibaRabbitMQ.Simple模式
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
            this.rBoxSend = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.rBoxReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBoxSend
            // 
            this.rBoxSend.Location = new System.Drawing.Point(3, 3);
            this.rBoxSend.Name = "rBoxSend";
            this.rBoxSend.Size = new System.Drawing.Size(468, 157);
            this.rBoxSend.TabIndex = 0;
            this.rBoxSend.Text = "";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(491, 12);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(99, 32);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "SendMessage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // rBoxReceiveMessage
            // 
            this.rBoxReceiveMessage.Location = new System.Drawing.Point(3, 166);
            this.rBoxReceiveMessage.Name = "rBoxReceiveMessage";
            this.rBoxReceiveMessage.Size = new System.Drawing.Size(468, 157);
            this.rBoxReceiveMessage.TabIndex = 2;
            this.rBoxReceiveMessage.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "ReceiveMessage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 335);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rBoxReceiveMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.rBoxSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rBoxSend;
        private Button btnSendMessage;
        private RichTextBox rBoxReceiveMessage;
        private Button button1;
    }
}