using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularDeAutentificare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void idTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if (idTextBox.Text == "Dana")
                {
                    parolaTextBox.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Utilizatorul nu există");
                }
            }
        }

        private void parolaTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (parolaTextBox.Text == "parola")
                {
                    cnpLabel.Visible = true;
                    CNPTextBox.Visible = true;
                    AutentificareBtn.Visible = true;
                    CNPTextBox.Focus();
                }
                else
                {
                    MessageBox.Show("Parola incorectă");
                    parolaTextBox.Clear();
                }
            }
        }

        private void CNPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void AutentificareBtn_Click(object sender, EventArgs e)
        {
            if (CNPTextBox.Text.Length != 13)
            {
                MessageBox.Show("CNP incorect, scrieți din nou!");
                CNPTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Autentificare cu succes!");
            }
        }
    }
}
