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
        public List<Sandwich> Wiches = new List<Sandwich>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String bread = breadBox.Text;
            String meat = meatBox.Text;
            String cheese = cheeseBox.Text;
            bool[] condiments = {lettuce.Checked,
                                spinach.Checked,
                                tomato.Checked,
                                pickles.Checked,
                                pepper.Checked
            };
            Sandwich newSandwich = new Sandwich(name, bread, meat, cheese, condiments);
            Wiches.Add(newSandwich);
            ordersBox.Items.Add(newSandwich.Name);
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            SummaryForm sumDlg = new SummaryForm();
            sumDlg.sandwiches = Wiches;
            sumDlg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
