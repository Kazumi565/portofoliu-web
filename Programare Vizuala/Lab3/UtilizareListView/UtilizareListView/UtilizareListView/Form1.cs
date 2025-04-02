using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilizareListView
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void SeteazaLista()
        {
            eleviListView.Columns.Add("Nume", 200, HorizontalAlignment.Left);
            eleviListView.Columns.Add("Prenume", 200, HorizontalAlignment.Left);
            eleviListView.Columns.Add("Nota", 200, HorizontalAlignment.Left);
            eleviListView.View = View.Details;
            eleviListView.Sorting = SortOrder.Ascending;
            eleviListView.AllowColumnReorder = true;
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            this.eleviListView.BeginUpdate();
            ListViewItem a;
            ListViewItem.ListViewSubItem b;

            foreach (Elev c in Elev.CitesteElevi())
            {
                a = new ListViewItem();
                a.Text = c.Nume;

                b = new ListViewItem.ListViewSubItem();
                b.Text = c.Prenume;
                a.SubItems.Add(b);

                b = new ListViewItem.ListViewSubItem();
                b.Text = c.Nota.ToString();
                a.SubItems.Add(b);

                eleviListView.Items.Add(a);
            }

            this.eleviListView.EndUpdate();
            SeteazaLista();
        }

    }
}
