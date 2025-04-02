namespace NumereIntregi
{
    partial class MyForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.RezultatTextBox = new System.Windows.Forms.TextBox();
            this.ParButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.PpButton = new System.Windows.Forms.Button();
            this.PrimeButton = new System.Windows.Forms.Button();
            this.Prime2Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TitleLabel.Location = new System.Drawing.Point(178, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 18);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dați valoarea lui n";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nLabel.Location = new System.Drawing.Point(178, 37);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(179, 18);
            this.nLabel.TabIndex = 1;
            this.nLabel.Text = "Introduceți valoarea lui n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(178, 58);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 22);
            this.nTextBox.TabIndex = 2;
            // 
            // RezultatTextBox
            // 
            this.RezultatTextBox.Location = new System.Drawing.Point(30, 250);
            this.RezultatTextBox.Multiline = true;
            this.RezultatTextBox.Name = "RezultatTextBox";
            this.RezultatTextBox.ReadOnly = true;
            this.RezultatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RezultatTextBox.Size = new System.Drawing.Size(420, 100);
            this.RezultatTextBox.TabIndex = 3;
            // 
            // ParButton
            // 
            this.ParButton.AutoSize = true;
            this.ParButton.Location = new System.Drawing.Point(2, 93);
            this.ParButton.Name = "ParButton";
            this.ParButton.Size = new System.Drawing.Size(168, 30);
            this.ParButton.TabIndex = 4;
            this.ParButton.Text = "Afișează numere pare";
            this.ParButton.UseVisualStyleBackColor = true;
            this.ParButton.Click += new System.EventHandler(this.ParButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.AutoSize = true;
            this.DivButton.Location = new System.Drawing.Point(2, 138);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(203, 30);
            this.DivButton.TabIndex = 5;
            this.DivButton.Text = "Afișează divizibile cu 3 și 5";
            this.DivButton.UseVisualStyleBackColor = true;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // PpButton
            // 
            this.PpButton.AutoSize = true;
            this.PpButton.Location = new System.Drawing.Point(176, 93);
            this.PpButton.Name = "PpButton";
            this.PpButton.Size = new System.Drawing.Size(191, 30);
            this.PpButton.TabIndex = 6;
            this.PpButton.Text = "Afișează pătrate perfecte";
            this.PpButton.UseVisualStyleBackColor = true;
            this.PpButton.Click += new System.EventHandler(this.PpButton_Click);
            // 
            // PrimeButton
            // 
            this.PrimeButton.AutoSize = true;
            this.PrimeButton.Location = new System.Drawing.Point(211, 138);
            this.PrimeButton.Name = "PrimeButton";
            this.PrimeButton.Size = new System.Drawing.Size(175, 30);
            this.PrimeButton.TabIndex = 7;
            this.PrimeButton.Text = "Afișează numere prime";
            this.PrimeButton.UseVisualStyleBackColor = true;
            this.PrimeButton.Click += new System.EventHandler(this.PrimeButton_Click);
            // 
            // Prime2Button
            // 
            this.Prime2Button.AutoSize = true;
            this.Prime2Button.Location = new System.Drawing.Point(2, 184);
            this.Prime2Button.Name = "Prime2Button";
            this.Prime2Button.Size = new System.Drawing.Size(248, 30);
            this.Prime2Button.TabIndex = 8;
            this.Prime2Button.Text = "Afișează 2 prime mai mici decât n";
            this.Prime2Button.UseVisualStyleBackColor = true;
            this.Prime2Button.Click += new System.EventHandler(this.Prime2Button_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Prime2Button);
            this.Controls.Add(this.PrimeButton);
            this.Controls.Add(this.PpButton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.ParButton);
            this.Controls.Add(this.RezultatTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyForm";
            this.Text = "Afișarea numerelor mai mici ca un n dat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox RezultatTextBox;
        private System.Windows.Forms.Button ParButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button PpButton;
        private System.Windows.Forms.Button PrimeButton;
        private System.Windows.Forms.Button Prime2Button;
    }
}

