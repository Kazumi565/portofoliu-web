namespace TestRadioButtons
{
    partial class testRdBtnForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.typeGroup = new System.Windows.Forms.GroupBox();
            this.RetCancelBtn = new System.Windows.Forms.RadioButton();
            this.YesNoRdBtn = new System.Windows.Forms.RadioButton();
            this.YesNoCancelRdBtn = new System.Windows.Forms.RadioButton();
            this.AbRetIgRdBtn = new System.Windows.Forms.RadioButton();
            this.OkCancelRdBtn = new System.Windows.Forms.RadioButton();
            this.OkRdBtn = new System.Windows.Forms.RadioButton();
            this.iconGroup = new System.Windows.Forms.GroupBox();
            this.QuestRdBtn = new System.Windows.Forms.RadioButton();
            this.InfoRdBtn = new System.Windows.Forms.RadioButton();
            this.ExclamRdBtn = new System.Windows.Forms.RadioButton();
            this.ErrorRdBtn = new System.Windows.Forms.RadioButton();
            this.DisplayBtn = new System.Windows.Forms.Button();
            this.typeGroup.SuspendLayout();
            this.iconGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(362, 129);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(378, 18);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Alegeți tipul de MessageBox pe care doriți să-l afișați";
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(543, 373);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(0, 18);
            this.DisplayLabel.TabIndex = 1;
            // 
            // typeGroup
            // 
            this.typeGroup.Controls.Add(this.RetCancelBtn);
            this.typeGroup.Controls.Add(this.YesNoRdBtn);
            this.typeGroup.Controls.Add(this.YesNoCancelRdBtn);
            this.typeGroup.Controls.Add(this.AbRetIgRdBtn);
            this.typeGroup.Controls.Add(this.OkCancelRdBtn);
            this.typeGroup.Controls.Add(this.OkRdBtn);
            this.typeGroup.Location = new System.Drawing.Point(159, 194);
            this.typeGroup.Name = "typeGroup";
            this.typeGroup.Size = new System.Drawing.Size(200, 197);
            this.typeGroup.TabIndex = 2;
            this.typeGroup.TabStop = false;
            this.typeGroup.Text = "Button Type";
            // 
            // RetCancelBtn
            // 
            this.RetCancelBtn.AutoSize = true;
            this.RetCancelBtn.Location = new System.Drawing.Point(7, 162);
            this.RetCancelBtn.Name = "RetCancelBtn";
            this.RetCancelBtn.Size = new System.Drawing.Size(99, 22);
            this.RetCancelBtn.TabIndex = 5;
            this.RetCancelBtn.TabStop = true;
            this.RetCancelBtn.Text = "RetryCancel";
            this.RetCancelBtn.UseVisualStyleBackColor = true;
            this.RetCancelBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // YesNoRdBtn
            // 
            this.YesNoRdBtn.AutoSize = true;
            this.YesNoRdBtn.Location = new System.Drawing.Point(7, 134);
            this.YesNoRdBtn.Name = "YesNoRdBtn";
            this.YesNoRdBtn.Size = new System.Drawing.Size(66, 22);
            this.YesNoRdBtn.TabIndex = 4;
            this.YesNoRdBtn.TabStop = true;
            this.YesNoRdBtn.Text = "YesNo";
            this.YesNoRdBtn.UseVisualStyleBackColor = true;
            this.YesNoRdBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // YesNoCancelRdBtn
            // 
            this.YesNoCancelRdBtn.AutoSize = true;
            this.YesNoCancelRdBtn.Location = new System.Drawing.Point(7, 106);
            this.YesNoCancelRdBtn.Name = "YesNoCancelRdBtn";
            this.YesNoCancelRdBtn.Size = new System.Drawing.Size(107, 22);
            this.YesNoCancelRdBtn.TabIndex = 3;
            this.YesNoCancelRdBtn.TabStop = true;
            this.YesNoCancelRdBtn.Text = "YesNoCancel";
            this.YesNoCancelRdBtn.UseVisualStyleBackColor = true;
            this.YesNoCancelRdBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // AbRetIgRdBtn
            // 
            this.AbRetIgRdBtn.AutoSize = true;
            this.AbRetIgRdBtn.Location = new System.Drawing.Point(7, 78);
            this.AbRetIgRdBtn.Name = "AbRetIgRdBtn";
            this.AbRetIgRdBtn.Size = new System.Drawing.Size(131, 22);
            this.AbRetIgRdBtn.TabIndex = 2;
            this.AbRetIgRdBtn.TabStop = true;
            this.AbRetIgRdBtn.Text = "AbortRetryIgnore";
            this.AbRetIgRdBtn.UseVisualStyleBackColor = true;
            this.AbRetIgRdBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // OkCancelRdBtn
            // 
            this.OkCancelRdBtn.AutoSize = true;
            this.OkCancelRdBtn.Location = new System.Drawing.Point(7, 51);
            this.OkCancelRdBtn.Name = "OkCancelRdBtn";
            this.OkCancelRdBtn.Size = new System.Drawing.Size(88, 22);
            this.OkCancelRdBtn.TabIndex = 1;
            this.OkCancelRdBtn.TabStop = true;
            this.OkCancelRdBtn.Text = "OKCancel";
            this.OkCancelRdBtn.UseVisualStyleBackColor = true;
            this.OkCancelRdBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // OkRdBtn
            // 
            this.OkRdBtn.AutoSize = true;
            this.OkRdBtn.Location = new System.Drawing.Point(7, 23);
            this.OkRdBtn.Name = "OkRdBtn";
            this.OkRdBtn.Size = new System.Drawing.Size(47, 22);
            this.OkRdBtn.TabIndex = 0;
            this.OkRdBtn.TabStop = true;
            this.OkRdBtn.Text = "OK";
            this.OkRdBtn.UseVisualStyleBackColor = true;
            this.OkRdBtn.CheckedChanged += new System.EventHandler(this.OkRdBtn_CheckedChanged);
            // 
            // iconGroup
            // 
            this.iconGroup.Controls.Add(this.QuestRdBtn);
            this.iconGroup.Controls.Add(this.InfoRdBtn);
            this.iconGroup.Controls.Add(this.ExclamRdBtn);
            this.iconGroup.Controls.Add(this.ErrorRdBtn);
            this.iconGroup.Location = new System.Drawing.Point(675, 194);
            this.iconGroup.Name = "iconGroup";
            this.iconGroup.Size = new System.Drawing.Size(200, 197);
            this.iconGroup.TabIndex = 3;
            this.iconGroup.TabStop = false;
            this.iconGroup.Text = "Icon Type";
            // 
            // QuestRdBtn
            // 
            this.QuestRdBtn.AutoSize = true;
            this.QuestRdBtn.Location = new System.Drawing.Point(6, 106);
            this.QuestRdBtn.Name = "QuestRdBtn";
            this.QuestRdBtn.Size = new System.Drawing.Size(81, 22);
            this.QuestRdBtn.TabIndex = 9;
            this.QuestRdBtn.TabStop = true;
            this.QuestRdBtn.Text = "Question";
            this.QuestRdBtn.UseVisualStyleBackColor = true;
            this.QuestRdBtn.CheckedChanged += new System.EventHandler(this.ErrorRdBtn_CheckedChanged);
            // 
            // InfoRdBtn
            // 
            this.InfoRdBtn.AutoSize = true;
            this.InfoRdBtn.Location = new System.Drawing.Point(6, 79);
            this.InfoRdBtn.Name = "InfoRdBtn";
            this.InfoRdBtn.Size = new System.Drawing.Size(98, 22);
            this.InfoRdBtn.TabIndex = 8;
            this.InfoRdBtn.TabStop = true;
            this.InfoRdBtn.Text = "Information";
            this.InfoRdBtn.UseVisualStyleBackColor = true;
            this.InfoRdBtn.CheckedChanged += new System.EventHandler(this.ErrorRdBtn_CheckedChanged);
            // 
            // ExclamRdBtn
            // 
            this.ExclamRdBtn.AutoSize = true;
            this.ExclamRdBtn.Location = new System.Drawing.Point(6, 51);
            this.ExclamRdBtn.Name = "ExclamRdBtn";
            this.ExclamRdBtn.Size = new System.Drawing.Size(100, 22);
            this.ExclamRdBtn.TabIndex = 7;
            this.ExclamRdBtn.TabStop = true;
            this.ExclamRdBtn.Text = "Exclamation";
            this.ExclamRdBtn.UseVisualStyleBackColor = true;
            this.ExclamRdBtn.CheckedChanged += new System.EventHandler(this.ErrorRdBtn_CheckedChanged);
            // 
            // ErrorRdBtn
            // 
            this.ErrorRdBtn.AutoSize = true;
            this.ErrorRdBtn.Location = new System.Drawing.Point(6, 23);
            this.ErrorRdBtn.Name = "ErrorRdBtn";
            this.ErrorRdBtn.Size = new System.Drawing.Size(56, 22);
            this.ErrorRdBtn.TabIndex = 6;
            this.ErrorRdBtn.TabStop = true;
            this.ErrorRdBtn.Text = "Error";
            this.ErrorRdBtn.UseVisualStyleBackColor = true;
            this.ErrorRdBtn.CheckedChanged += new System.EventHandler(this.ErrorRdBtn_CheckedChanged);
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(478, 465);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBtn.TabIndex = 4;
            this.DisplayBtn.Text = "Afisează";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // testRdBtnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.iconGroup);
            this.Controls.Add(this.typeGroup);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.InfoLabel);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "testRdBtnForm";
            this.Text = "RadioButtons";
            this.Load += new System.EventHandler(this.testRdBtnForm_Load);
            this.typeGroup.ResumeLayout(false);
            this.typeGroup.PerformLayout();
            this.iconGroup.ResumeLayout(false);
            this.iconGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.GroupBox typeGroup;
        private System.Windows.Forms.GroupBox iconGroup;
        private System.Windows.Forms.RadioButton RetCancelBtn;
        private System.Windows.Forms.RadioButton YesNoRdBtn;
        private System.Windows.Forms.RadioButton YesNoCancelRdBtn;
        private System.Windows.Forms.RadioButton AbRetIgRdBtn;
        private System.Windows.Forms.RadioButton OkCancelRdBtn;
        private System.Windows.Forms.RadioButton OkRdBtn;
        private System.Windows.Forms.RadioButton QuestRdBtn;
        private System.Windows.Forms.RadioButton InfoRdBtn;
        private System.Windows.Forms.RadioButton ExclamRdBtn;
        private System.Windows.Forms.RadioButton ErrorRdBtn;
        private System.Windows.Forms.Button DisplayBtn;
    }
}

