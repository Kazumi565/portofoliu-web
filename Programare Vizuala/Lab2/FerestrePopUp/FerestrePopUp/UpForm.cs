using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerestrePopUp
{
    public partial class UpForm : Form
    {
        public UpForm()
        {
            InitializeComponent();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aplCeas_Tick(object sender, EventArgs e)
        {
            DateTime DataCurenta = DateTime.Now;
            labelCeas.Text = DataCurenta.ToLongTimeString();
        }
    }
}
