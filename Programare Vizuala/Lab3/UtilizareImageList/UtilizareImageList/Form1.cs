using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizareImageList
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics grafic = this.CreateGraphics();
            for (int i = 0; i < MyImageList.Images.Count; i++)
                MyImageList.Draw(grafic, i * 150 + 20, 80, i);
            grafic.Dispose();
        }
    }
}
