namespace KibaRabbitMQ._3.PulishSubscribe发布订阅模式
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
            this.rBoxSendMessage = new System.Windows.Forms.RichTextBox();
            this.rBoxReceiveMesssage1 = new System.Windows.Forms.RichTextBox();
            this.rBoxReceiveMesssage2 = new System.Windows.Forms.RichTextBox();
            this.rBoxReceiveMesssage3 = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnReceiveMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rBoxSendMessage
            // 
            this.rBoxSendMessage.Location = new System.Drawing.Point(2, 2);
            this.rBoxSendMessage.Name = "rBoxSendMessage";
            this.rBoxSendMessage.Size = new System.Drawing.Size(568, 121);
            this.rBoxSendMessage.TabIndex = 0;
            this.rBoxSendMessage.Text = "";
            // 
            // rBoxReceiveMesssage1
            // 
            this.rBoxReceiveMesssage1.Location = new System.Drawing.Point(2, 129);
            this.rBoxReceiveMesssage1.Name = "rBoxReceiveMesssage1";
            this.rBoxReceiveMesssage1.Size = new System.Drawing.Size(228, 318);
            this.rBoxReceiveMesssage1.TabIndex = 1;
            this.rBoxReceiveMesssage1.Text = "";
            // 
            // rBoxReceiveMesssage2
            // 
            this.rBoxReceiveMesssage2.Location = new System.Drawing.Point(236, 129);
            this.rBoxReceiveMesssage2.Name = "rBoxReceiveMesssage2";
            this.rBoxReceiveMesssage2.Size = new System.Drawing.Size(228, 318);
            this.rBoxReceiveMesssage2.TabIndex = 2;
            this.rBoxReceiveMesssage2.Text = "";
            // 
            // rBoxReceiveMesssage3
            // 
            this.rBoxReceiveMesssage3.Location = new System.Drawing.Point(470, 129);
            this.rBoxReceiveMesssage3.Name = "rBoxReceiveMesssage3";
            this.rBoxReceiveMesssage3.Size = new System.Drawing.Size(228, 318);
            this.rBoxReceiveMesssage3.TabIndex = 3;
            this.rBoxReceiveMesssage3.Text = "";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(576, 12);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(100, 29);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "SendMessage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnReceiveMessage
            // 
            this.btnReceiveMessage.Location = new System.Drawing.Point(590, 94);
            this.btnReceiveMessage.Name = "btnReceiveMessage";
            this.btnReceiveMessage.Size = new System.Drawing.Size(108, 29);
            this.btnReceiveMessage.TabIndex = 5;
            this.btnReceiveMessage.Text = "ReceiveMessage";
            this.btnReceiveMessage.UseVisualStyleBackColor = true;
            this.btnReceiveMessage.Click += new System.EventHandler(this.btnReceiveMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.btnReceiveMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.rBoxReceiveMesssage3);
            this.Controls.Add(this.rBoxReceiveMesssage2);
            this.Controls.Add(this.rBoxReceiveMesssage1);
            this.Controls.Add(this.rBoxSendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rBoxSendMessage;
        private RichTextBox rBoxReceiveMesssage1;
        private RichTextBox rBoxReceiveMesssage2;
        private RichTextBox rBoxReceiveMesssage3;
        private Button btnSendMessage;
        private Button btnReceiveMessage;
    }
}