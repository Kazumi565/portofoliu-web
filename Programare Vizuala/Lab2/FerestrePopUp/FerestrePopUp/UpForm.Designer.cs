namespace FerestrePopUp
{
    partial class UpForm
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
            this.components = new System.ComponentModel.Container();
            this.UpButton = new System.Windows.Forms.Button();
            this.clockQuestionLabel = new System.Windows.Forms.Label();
            this.labelCeas = new System.Windows.Forms.Label();
            this.aplCeas = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UpButton
            // 
            this.UpButton.AutoSize = true;
            this.UpButton.Location = new System.Drawing.Point(198, 212);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 26);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Close";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // clockQuestionLabel
            // 
            this.clockQuestionLabel.AutoSize = true;
            this.clockQuestionLabel.Location = new System.Drawing.Point(67, 21);
            this.clockQuestionLabel.Name = "clockQuestionLabel";
            this.clockQuestionLabel.Size = new System.Drawing.Size(164, 16);
            this.clockQuestionLabel.TabIndex = 1;
            this.clockQuestionLabel.Text = "Care este ora curentă?";
            // 
            // labelCeas
            // 
            this.labelCeas.AutoSize = true;
            this.labelCeas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCeas.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCeas.Location = new System.Drawing.Point(38, 90);
            this.labelCeas.Name = "labelCeas";
            this.labelCeas.Size = new System.Drawing.Size(2, 43);
            this.labelCeas.TabIndex = 2;
            this.labelCeas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aplCeas
            // 
            this.aplCeas.Enabled = true;
            this.aplCeas.Interval = 1000;
            this.aplCeas.Tick += new System.EventHandler(this.aplCeas_Tick);
            // 
            // UpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(294, 261);
            this.Controls.Add(this.labelCeas);
            this.Controls.Add(this.clockQuestionLabel);
            this.Controls.Add(this.UpButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpForm";
            this.Text = "UpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Label clockQuestionLabel;
        private System.Windows.Forms.Label labelCeas;
        private System.Windows.Forms.Timer aplCeas;
    }
}