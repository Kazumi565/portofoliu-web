namespace FormularDeAutentificare
{
    partial class Form1
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
            this.idLabel = new System.Windows.Forms.Label();
            this.parolaLabel = new System.Windows.Forms.Label();
            this.cnpLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.parolaTextBox = new System.Windows.Forms.TextBox();
            this.CNPTextBox = new System.Windows.Forms.TextBox();
            this.AutentificareBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(247, 83);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID:";
            // 
            // parolaLabel
            // 
            this.parolaLabel.AutoSize = true;
            this.parolaLabel.Location = new System.Drawing.Point(320, 83);
            this.parolaLabel.Name = "parolaLabel";
            this.parolaLabel.Size = new System.Drawing.Size(40, 13);
            this.parolaLabel.TabIndex = 1;
            this.parolaLabel.Text = "Parolă:";
            // 
            // cnpLabel
            // 
            this.cnpLabel.AutoSize = true;
            this.cnpLabel.Location = new System.Drawing.Point(418, 83);
            this.cnpLabel.Name = "cnpLabel";
            this.cnpLabel.Size = new System.Drawing.Size(32, 13);
            this.cnpLabel.TabIndex = 2;
            this.cnpLabel.Text = "CNP:";
            this.cnpLabel.Visible = false;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(383, 176);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 3;
            this.idTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.idTextBox_PreviewKeyDown);
            // 
            // parolaTextBox
            // 
            this.parolaTextBox.Enabled = false;
            this.parolaTextBox.Location = new System.Drawing.Point(383, 213);
            this.parolaTextBox.Name = "parolaTextBox";
            this.parolaTextBox.PasswordChar = '*';
            this.parolaTextBox.Size = new System.Drawing.Size(100, 20);
            this.parolaTextBox.TabIndex = 4;
            this.parolaTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.parolaTextBox_PreviewKeyDown);
            // 
            // CNPTextBox
            // 
            this.CNPTextBox.Location = new System.Drawing.Point(383, 260);
            this.CNPTextBox.Name = "CNPTextBox";
            this.CNPTextBox.Size = new System.Drawing.Size(100, 20);
            this.CNPTextBox.TabIndex = 5;
            this.CNPTextBox.Visible = false;
            this.CNPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CNPTextBox_KeyPress);
            // 
            // AutentificareBtn
            // 
            this.AutentificareBtn.Location = new System.Drawing.Point(606, 260);
            this.AutentificareBtn.Name = "AutentificareBtn";
            this.AutentificareBtn.Size = new System.Drawing.Size(75, 23);
            this.AutentificareBtn.TabIndex = 6;
            this.AutentificareBtn.Text = "Autentificare";
            this.AutentificareBtn.UseVisualStyleBackColor = true;
            this.AutentificareBtn.Visible = false;
            this.AutentificareBtn.Click += new System.EventHandler(this.AutentificareBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AutentificareBtn);
            this.Controls.Add(this.CNPTextBox);
            this.Controls.Add(this.parolaTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.cnpLabel);
            this.Controls.Add(this.parolaLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label parolaLabel;
        private System.Windows.Forms.Label cnpLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox parolaTextBox;
        private System.Windows.Forms.TextBox CNPTextBox;
        private System.Windows.Forms.Button AutentificareBtn;
    }
}

