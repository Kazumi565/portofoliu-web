namespace FerestrePopUp
{
    partial class PasswordForm
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
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.AutoSize = true;
            this.displayPasswordLabel.Location = new System.Drawing.Point(213, 132);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(0, 16);
            this.displayPasswordLabel.TabIndex = 0;
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPasswordTextBox.ForeColor = System.Drawing.Color.Navy;
            this.inputPasswordTextBox.Location = new System.Drawing.Point(309, 92);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.PasswordChar = '*';
            this.inputPasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.inputPasswordTextBox.TabIndex = 1;
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.AutoSize = true;
            this.showPasswordButton.Location = new System.Drawing.Point(585, 124);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(83, 26);
            this.showPasswordButton.TabIndex = 2;
            this.showPasswordButton.Text = "Show me!";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            this.showPasswordButton.Click += new System.EventHandler(this.showPasswordButton_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.showPasswordButton);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Button showPasswordButton;
    }
}