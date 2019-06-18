using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_11._5
{
    public partial class Form1 : Form
    {
        List<Person> People = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            try
            {
                readBlackbook();

            } catch { }
        }

        private void writeBlackbook()
        {
            StreamWriter writer = new StreamWriter("Blackbook.txt");

            foreach (Person p in People)
            {
                String output = p.Name + "," + p.PhoneNo + "," + p.PagerNo + "," + p.CellNo + "," + p.VoicemailNo + "," + p.Email;

                writer.WriteLine(output);
            }

            writer.Close();
        }
        private void readBlackbook()
        {
            StreamReader reader = new StreamReader("Blackbook.txt");

            String input = reader.ReadLine();
            while (input != null)
            {
                String[] data = input.Split(',');
                Person newPerson = new Person(data[0], data[1], data[2], data[3], data[4], data[5]);
                People.Add(newPerson);
                blackBook.Items.Add(newPerson.Name);
                input = reader.ReadLine();
            }
            reader.Close();
        }


        private void addButton_Click(object sender, EventArgs e)
        {


            Person p = new Person(nameBox.Text, phoneBox.Text, cellBox.Text, voicemailBox.Text, pagerBox.Text, emailBox.Text);
            People.Add(p);
            blackBook.Items.Add(nameBox.Text);
            writeBlackbook();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blackBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Person selectedPerson = People[blackBook.SelectedIndex];
                nameBox.Text = selectedPerson.Name;
                phoneBox.Text = selectedPerson.PhoneNo;
                cellBox.Text = selectedPerson.PagerNo;
                voicemailBox.Text = selectedPerson.CellNo;
                pagerBox.Text = selectedPerson.VoicemailNo;
                emailBox.Text = selectedPerson.Email;
            } catch
            {
                MessageBox.Show("Please select a valid person.");
            }
        }
    }
}
