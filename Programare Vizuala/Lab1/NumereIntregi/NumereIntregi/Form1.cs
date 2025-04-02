using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumereIntregi
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void ParButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nTextBox.Text, out int n))
            {
                string result = "";
                for (int i = 2; i < n; i += 2)
                {
                    result += i + " ";
                }
                RezultatTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Introduceți un număr întreg valid!");
            }
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nTextBox.Text, out int n))
            {
                string result = "";
                for (int i = 1; i < n; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        result += i + " ";
                    }
                }
                RezultatTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Introduceți un număr întreg valid!");
            }
        }

        private void PpButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nTextBox.Text, out int n))
            {
                string result = "";
                for (int i = 1; i * i < n; i++)
                {
                    result += (i * i) + " ";
                }
                RezultatTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Introduceți un număr întreg valid!");
            }
        }

        private void PrimeButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nTextBox.Text, out int n))
            {
                string result = "";
                for (int i = 2; i < n; i++)
                {
                    if (EstePrim(i))
                        result += i + " ";
                }
                RezultatTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Introduceți un număr întreg valid!");
            }
        }

        private void Prime2Button_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nTextBox.Text, out int n))
            {
                string result = "";
                int count = 0;
                for (int i = n - 1; i >= 2 && count < 2; i--)
                {
                    if (EstePrim(i))
                    {
                        result = i + " " + result;
                        count++;
                    }
                }

                if (count == 2)
                    RezultatTextBox.Text = result;
                else
                    RezultatTextBox.Text = "Nu există 2 numere prime mai mici decât " + n;
            }
            else
            {
                MessageBox.Show("Introduceți un număr întreg valid!");
            }
        }

        private bool EstePrim(int numar)
        {
            if (numar < 2) return false;
            for (int i = 2; i * i <= numar; i++)
                if (numar % i == 0)
                    return false;
            return true;
        }
    }
}
