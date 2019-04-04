using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_Pet_12._11
{
    public partial class Form1 : Form
    {
        public List<Pet> pets = new List<Pet>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String type = typeBox.Text;
            String breed = breedBox.Text;
            String color = colorBox.Text;
            Pet newPet = new Pet(name, type, breed, color);
            pets.Add(newPet);
            nameBox.Text = "";
            typeBox.Text = "";
            breedBox.Text = "";
            colorBox.Text = "";
        }

        private void buttonViewSummary_Click(object sender, EventArgs e)
        {
            SummaryForm sumDlg = new SummaryForm();
            sumDlg.Pets = pets;
            sumDlg.ShowDialog();
        }
    }
}
