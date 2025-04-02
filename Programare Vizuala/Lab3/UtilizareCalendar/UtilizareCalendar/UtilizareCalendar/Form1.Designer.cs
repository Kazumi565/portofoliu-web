namespace UtilizareCalendar
{
    partial class mainForm
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
            this.myMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.myComboBox = new System.Windows.Forms.ComboBox();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myMonthCalendar
            // 
            this.myMonthCalendar.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.myMonthCalendar.ForeColor = System.Drawing.Color.Navy;
            this.myMonthCalendar.Location = new System.Drawing.Point(371, 98);
            this.myMonthCalendar.MaxSelectionCount = 30;
            this.myMonthCalendar.Name = "myMonthCalendar";
            this.myMonthCalendar.ShowTodayCircle = false;
            this.myMonthCalendar.ShowWeekNumbers = true;
            this.myMonthCalendar.TabIndex = 0;
            this.myMonthCalendar.TitleBackColor = System.Drawing.Color.DarkMagenta;
            this.myMonthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.myMonthCalendar_DateSelected);
            // 
            // myComboBox
            // 
            this.myComboBox.FormattingEnabled = true;
            this.myComboBox.Location = new System.Drawing.Point(777, 145);
            this.myComboBox.Name = "myComboBox";
            this.myComboBox.Size = new System.Drawing.Size(121, 24);
            this.myComboBox.TabIndex = 1;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(750, 263);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(0, 16);
            this.myLabel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myComboBox);
            this.Controls.Add(this.myMonthCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilizare Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar myMonthCalendar;
        private System.Windows.Forms.ComboBox myComboBox;
        private System.Windows.Forms.Label myLabel;
    }
}

