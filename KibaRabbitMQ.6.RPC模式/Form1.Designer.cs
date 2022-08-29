namespace KibaRabbitMQ._6.RPC模式
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SendMessage = new System.Windows.Forms.Button();
            this.ReceiveMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(270, 132);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 165);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(270, 132);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(284, 14);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(89, 52);
            this.SendMessage.TabIndex = 2;
            this.SendMessage.Text = "SendMessage";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // ReceiveMessage
            // 
            this.ReceiveMessage.Location = new System.Drawing.Point(285, 165);
            this.ReceiveMessage.Name = "ReceiveMessage";
            this.ReceiveMessage.Size = new System.Drawing.Size(89, 52);
            this.ReceiveMessage.TabIndex = 3;
            this.ReceiveMessage.Text = "ReceiveMessage";
            this.ReceiveMessage.UseVisualStyleBackColor = true;
            this.ReceiveMessage.Click += new System.EventHandler(this.ReceiveMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 316);
            this.Controls.Add(this.ReceiveMessage);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button SendMessage;
        private Button ReceiveMessage;
    }
}