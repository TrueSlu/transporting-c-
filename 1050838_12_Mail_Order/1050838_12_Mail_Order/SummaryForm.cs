using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_12_Mail_Order
{
    public partial class SummaryForm : Form
    {
        public List<Item> Orders { get; set; }
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            foreach (Item orderItem in Orders)
            {
                ordersBox.Items.Add(orderItem.Description);
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Item orderItem = Orders[ordersBox.SelectedIndex];
                descriptionBox.Text = orderItem.Description;
                quantityBox.Text = orderItem.Quantity.ToString();
                weightBox.Text = orderItem.Weight.ToString();
                priceBox.Text = orderItem.Price.ToString();
                taxBox.Text = orderItem.Tax.ToString();
                shippingBox.Text = orderItem.HandlingPrice.ToString();
            }
            catch
            {
                MessageBox.Show("That's not a correct order.");
            }
        }
    }
}
