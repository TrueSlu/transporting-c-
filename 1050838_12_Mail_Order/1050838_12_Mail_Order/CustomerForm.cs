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
    public partial class CustomerForm : Form
    {

        public new String Name { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = Name;
            addressBox.Text = Address;
            cityBox.Text = City;
            stateBox.Text = State;
            zipBox.Text = Zip.ToString();
        }
    }
}
