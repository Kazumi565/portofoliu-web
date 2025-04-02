using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizareCalendar
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void myMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            myLabel.Text = "Intervalul selectat: Start = " +
                   e.Start.ToShortDateString() +
                   " End = " + e.End.ToShortDateString();

            if (e.Start.ToShortDateString() == e.End.ToShortDateString())
            {
                string x = e.Start.ToShortDateString();
                if (!myComboBox.Items.Contains(x))
                    myComboBox.Items.Add(x);
            }
        }
    }
}
