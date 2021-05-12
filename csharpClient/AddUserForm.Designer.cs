
namespace csharpClient
{
    partial class AddUserForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idNoBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionLabel.Location = new System.Drawing.Point(9, 22);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(187, 17);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "User ID to add to group chat";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(13, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(246, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Close";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 65);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(128, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "#";
            // 
            // idNoBox
            // 
            this.idNoBox.Location = new System.Drawing.Point(140, 43);
            this.idNoBox.Name = "idNoBox";
            this.idNoBox.Size = new System.Drawing.Size(78, 20);
            this.idNoBox.TabIndex = 3;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 43);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(110, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 141);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.idNoBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.instructionLabel);
            this.MaximumSize = new System.Drawing.Size(350, 180);
            this.MinimumSize = new System.Drawing.Size(350, 180);
            this.Name = "AddUserForm";
            this.Text = "Add User to Group Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idNoBox;
        private System.Windows.Forms.TextBox usernameBox;
    }
}