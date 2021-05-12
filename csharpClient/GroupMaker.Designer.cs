
namespace csharpClient
{
    partial class GroupMaker
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
            this.groupNamerBox = new System.Windows.Forms.MaskedTextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupNamerBox
            // 
            this.groupNamerBox.Location = new System.Drawing.Point(12, 42);
            this.groupNamerBox.Name = "groupNamerBox";
            this.groupNamerBox.Size = new System.Drawing.Size(310, 20);
            this.groupNamerBox.TabIndex = 1;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.instructionLabel.Location = new System.Drawing.Point(9, 22);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(182, 17);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Name your new group chat:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(246, 106);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(12, 106);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(13, 69);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 5;
            // 
            // GroupMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 141);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.groupNamerBox);
            this.MaximumSize = new System.Drawing.Size(350, 180);
            this.MinimumSize = new System.Drawing.Size(350, 180);
            this.Name = "GroupMaker";
            this.Text = "Make a group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox groupNamerBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label errorLabel;
    }
}