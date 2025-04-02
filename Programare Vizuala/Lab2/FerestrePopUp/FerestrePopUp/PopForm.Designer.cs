namespace FerestrePopUp
{
    partial class PopForm
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
            this.PopButton = new System.Windows.Forms.Button();
            this.CalendarControl = new System.Windows.Forms.MonthCalendar();
            this.dateQuestionLabel = new System.Windows.Forms.Label();
            this.PasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PopButton
            // 
            this.PopButton.AutoSize = true;
            this.PopButton.Location = new System.Drawing.Point(215, 208);
            this.PopButton.Name = "PopButton";
            this.PopButton.Size = new System.Drawing.Size(75, 26);
            this.PopButton.TabIndex = 0;
            this.PopButton.Text = "Next";
            this.PopButton.UseVisualStyleBackColor = true;
            this.PopButton.Click += new System.EventHandler(this.PopButton_Click);
            // 
            // CalendarControl
            // 
            this.CalendarControl.Location = new System.Drawing.Point(44, 34);
            this.CalendarControl.Name = "CalendarControl";
            this.CalendarControl.TabIndex = 1;
            // 
            // dateQuestionLabel
            // 
            this.dateQuestionLabel.AutoSize = true;
            this.dateQuestionLabel.Location = new System.Drawing.Point(71, 9);
            this.dateQuestionLabel.Name = "dateQuestionLabel";
            this.dateQuestionLabel.Size = new System.Drawing.Size(172, 16);
            this.dateQuestionLabel.TabIndex = 2;
            this.dateQuestionLabel.Text = "Care este data curentă?";
            // 
            // PasswordButton
            // 
            this.PasswordButton.AutoSize = true;
            this.PasswordButton.Location = new System.Drawing.Point(22, 208);
            this.PasswordButton.Name = "PasswordButton";
            this.PasswordButton.Size = new System.Drawing.Size(117, 26);
            this.PasswordButton.TabIndex = 3;
            this.PasswordButton.Text = "Password App";
            this.PasswordButton.UseVisualStyleBackColor = true;
            this.PasswordButton.Click += new System.EventHandler(this.PasswordButton_Click);
            // 
            // PopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(313, 272);
            this.Controls.Add(this.PasswordButton);
            this.Controls.Add(this.dateQuestionLabel);
            this.Controls.Add(this.CalendarControl);
            this.Controls.Add(this.PopButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "PopForm";
            this.Text = "Pop form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PopButton;
        private System.Windows.Forms.MonthCalendar CalendarControl;
        private System.Windows.Forms.Label dateQuestionLabel;
        private System.Windows.Forms.Button PasswordButton;
    }
}

