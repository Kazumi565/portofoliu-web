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
    public partial class PopForm : Form
    {
        public PopForm()
        {
            InitializeComponent();
        }

        private void PopButton_Click(object sender, EventArgs e)
        {
            UpForm upForm = new UpForm();  // create instance of the second form
            upForm.ShowDialog();           // open it as a modal pop-up
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            PasswordForm passForm = new PasswordForm(); // create the form
            passForm.ShowDialog();
        }
    }
}
