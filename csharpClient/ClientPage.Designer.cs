
namespace csharpClient
{
    partial class ClientPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sendButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.senderBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.ListBox();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(933, 646);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 0;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1177, 646);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "log out";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // senderBox
            // 
            this.senderBox.Location = new System.Drawing.Point(13, 648);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(914, 20);
            this.senderBox.TabIndex = 2;
            // 
            // messageBox
            // 
            this.messageBox.FormattingEnabled = true;
            this.messageBox.Location = new System.Drawing.Point(13, 13);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(995, 615);
            this.messageBox.TabIndex = 3;
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Location = new System.Drawing.Point(1014, 12);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(238, 321);
            this.radioGroupBox.TabIndex = 6;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Enter += new System.EventHandler(this.radioGroupBox_Enter);
            // 
            // ClientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.radioGroupBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.senderBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendButton);
            this.Name = "ClientPage";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientPage_FormClosed);
            this.Load += new System.EventHandler(this.ClientPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox senderBox;
        private System.Windows.Forms.ListBox messageBox;
        private System.Windows.Forms.GroupBox radioGroupBox;
    }
}