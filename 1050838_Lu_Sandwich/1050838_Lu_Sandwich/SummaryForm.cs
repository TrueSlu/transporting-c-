using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_Sandwich
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        public List<Sandwich> Sandwiches { get; set; }

        private void Summary_Load(object sender, EventArgs e)
        {
            foreach (Sandwich s in Sandwiches)
            {
                listBoxOrders.Items.Add(s.Name);
            }
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sandwich s = Sandwiches[listBoxOrders.SelectedIndex];
            textBoxName.Text = s.Name;
            textBoxBread.Text = s.Bread;
            textBoxMeat.Text = s.Meat;
            textBoxCheese.Text = s.Cheese;
            checkBoxLuttuce.Checked = s.Condiments[0];
            checkBoxSpinach.Checked = s.Condiments[1];
            checkBoxTomato.Checked = s.Condiments[2];
            checkBoxPickles.Checked = s.Condiments[3];
            checkBoxPepper.Checked = s.Condiments[4];
            checkBoxRatWaste.Checked = s.Condiments[5];
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
