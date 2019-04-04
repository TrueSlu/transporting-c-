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
    public partial class Form1 : Form
    {
        public List<Sandwich> Sandwiches { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String bread = comboBoxBread.Text;
            String meat = comboBoxMeat.Text;
            String cheese = comboBoxCheese.Text;
            bool[] condiments = {checkBoxLuttuce.Checked,
                                checkBoxSpinach.Checked,
                                checkBoxTomato.Checked,
                                checkBoxPickles.Checked,
                                checkBoxPepper.Checked,
                                checkBoxRatWaste.Checked};
            Sandwich s = new Sandwich(name, bread, meat, cheese, condiments);
            Sandwiches.Add(s);
            listBoxOrders.Items.Add(s.Name);
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            SummaryForm sumDlg = new SummaryForm();
            sumDlg.Sandwiches = Sandwiches;
            sumDlg.ShowDialog();
        }
    }
}
