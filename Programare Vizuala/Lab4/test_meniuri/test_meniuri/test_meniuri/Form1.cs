using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test_meniuri
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void editTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Visible = false;

        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isBold = !((ToolStripMenuItem)sender).Checked;
            ((ToolStripMenuItem)sender).Checked = isBold;

            FontStyle newStyle = textBox1.Font.Style;

            if (isBold)
                newStyle |= FontStyle.Bold;
            else
                newStyle &= ~FontStyle.Bold;

            textBox1.Font = new Font(textBox1.Font.FontFamily, 14, newStyle);


        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = !((ToolStripMenuItem)sender).Checked;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 14,
                textBox1.Font.Style ^ FontStyle.Italic);

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            textBox1.ForeColor = Color.Red;
            ((ToolStripMenuItem)sender).Checked = true;

        }
        private void ClearColor()
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    var menuItem = subItem as ToolStripMenuItem;
                    if (menuItem != null)
                    {
                        string text = menuItem.Text.ToLower();
                        if (text == "red" || text == "blue" || text == "green" || text == "black")
                        {
                            menuItem.Checked = false;
                        }
                    }
                }
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            textBox1.ForeColor = Color.Blue;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            textBox1.ForeColor = Color.Green;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            textBox1.ForeColor = Color.Black;
            ((ToolStripMenuItem)sender).Checked = true;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();

        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Red;

        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Blue;

        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Green;

        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClearColor();
            displayLabel.ForeColor = Color.Black;

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exemplu de utilizare a meniurilor", "Informatii",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Courier New", 14, displayLabel.Font.Style);

        }

        private void comicSansSerifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);

        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14, displayLabel.Font.Style ^ FontStyle.Bold);

        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14, displayLabel.Font.Style ^ FontStyle.Italic);

        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayLabel.Font = new Font(displayLabel.Font.FontFamily, 14, FontStyle.Regular);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
