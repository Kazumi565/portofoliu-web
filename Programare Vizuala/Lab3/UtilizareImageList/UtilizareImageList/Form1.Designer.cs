namespace UtilizareImageList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.drawButton = new System.Windows.Forms.Button();
            this.MyImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.AutoSize = true;
            this.drawButton.Location = new System.Drawing.Point(344, 66);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(96, 26);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Deseneaza";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // MyImageList
            // 
            this.MyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImageList.ImageStream")));
            this.MyImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MyImageList.Images.SetKeyName(0, "download (1).jpg");
            this.MyImageList.Images.SetKeyName(1, "download (2).jpg");
            this.MyImageList.Images.SetKeyName(2, "download (3).jpg");
            this.MyImageList.Images.SetKeyName(3, "download (4).jpg");
            this.MyImageList.Images.SetKeyName(4, "download.jpg");
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 257);
            this.Controls.Add(this.drawButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "Utilizarea controlului ImageList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ImageList MyImageList;
    }
}

