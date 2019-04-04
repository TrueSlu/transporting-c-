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
    public partial class SummaryForm : Form
    {
        public List<Pet> Pets { get; set; }
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            foreach (Pet pet in Pets)
            {
                petsBox.Items.Add(pet.Name);
            }

            nameBoxSum.Enabled = false;
            typeBoxSum.Enabled = false;
            breedBoxSum.Enabled = false;
            colorBoxSum.Enabled = false;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void petsBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                Pet pet = Pets[petsBox.SelectedIndex];
                nameBoxSum.Text = pet.Name;
                typeBoxSum.Text = pet.Type;
                breedBoxSum.Text = pet.Breed;
                colorBoxSum.Text = pet.Color;
            } catch
            {

            }

        }
    }
}
