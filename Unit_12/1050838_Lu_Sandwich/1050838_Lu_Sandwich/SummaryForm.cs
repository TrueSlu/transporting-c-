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
        public List<Sandwich> sandwiches { get; set; }



        private void SummaryForm_Load(object sender, EventArgs e)
        {
            foreach (Sandwich s in sandwiches)
            {
                orders.Items.Add(s.Name);
            }
        }

        private void listBoxOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (orders.SelectedIndex > -1)
            {
                Sandwich s = sandwiches[orders.SelectedIndex];
                nameBox.Text = s.Name;
                breadBox.Text = s.Bread;
                meatBox.Text = s.Meat;
                cheeseBox.Text = s.Cheese;
                checkBoxLuttuce.Checked = s.Condiments[0];
                checkBoxSpinach.Checked = s.Condiments[1];
                checkBoxTomato.Checked = s.Condiments[2];
                checkBoxPickles.Checked = s.Condiments[3];
                checkBoxPepper.Checked = s.Condiments[4];
            }
        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
