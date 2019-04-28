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
    public partial class Form1 : Form
    {

        public List<Item> orders = new List<Item>();
        int quant;
        float weight;
        float price;
        float charge;
        float sandh;
        float tax;
        float total;

        String n;
        String a;
        String c;
        String s;
        int zipcode;


        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String description = descriptionBox.Text;
            try
            {
                quant = int.Parse(quantityBox.Text);

                try
                {
                    weight = float.Parse(weightBox.Text);

                    try
                    {
                        price = float.Parse(priceBox.Text);
                        charge = price * quant;
                        if (nameBox.Enabled == true)
                        {
                            //get vals
                            n = nameBox.Text;
                            a = addressBox.Text;
                            c = cityBox.Text;
                            s = stateBox.Text;
                            zipcode = int.Parse(zipBox.Text);

                            //new customer
                            Customer newCustomer = new Customer(n, a, c, s, zipcode);
                            Item newItem = new Item();
                            newItem.addCustomer(newCustomer);
                           
                            //disable customer boxes
                            nameBox.Enabled = false;
                            addressBox.Enabled = false;
                            cityBox.Enabled = false;
                            stateBox.Enabled = false;
                            zipBox.Enabled = false;
                        }

                        //clear boxes
                        descriptionBox.Text = "";
                        quantityBox.Text = "";
                        weightBox.Text = "";
                        priceBox.Text = "";

                        //new item
                        Item newItem2 = new Item(description, quant, weight, price);
                        orders.Add(newItem2);
                        ordersBox.Items.Add(description);

                        //calc values
                        sandh = newItem2.calculateShippingAndHandling(weight);
                        tax = newItem2.calculateSalesTax(price);
                        total = (price * quant) + sandh + tax;
                    }
                    catch
                    {
                        MessageBox.Show("Bad price");
                    }
                }
                catch
                {
                    MessageBox.Show("Bad weight");
                }
            }
            catch
            {
                MessageBox.Show("Bad quantity");
            }
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerSummary = new CustomerForm();
            customerSummary.Name = n;
            customerSummary.Address = a;
            customerSummary.City = c;
            customerSummary.State = s;
            customerSummary.Zip = zipcode;
            customerSummary.ShowDialog();
        }

        private void viewSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummaryForm newSummary = new SummaryForm();
            newSummary.Orders = orders;
            newSummary.ShowDialog();
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectedOrder = orders[ordersBox.SelectedIndex];
            descriptionBox.Text = selectedOrder.Description;
            quantityBox.Text = selectedOrder.Quantity.ToString();
            weightBox.Text = selectedOrder.Weight.ToString();
            priceBox.Text = selectedOrder.Price.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
