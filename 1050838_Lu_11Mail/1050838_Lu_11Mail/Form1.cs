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

namespace _1050838_Lu_11Mail
{
    public partial class Form1 : Form
    {

        List<String> catalogs = new List<String>();
        string currentFileGlobalVarLol = "Catalogs.txt";
        int changeCounter = 0;
        public Form1()
        {
            InitializeComponent();
            try
            {
                read(currentFileGlobalVarLol);
            } catch
            {
                writeNew();
                read(currentFileGlobalVarLol);
                MessageBox.Show("You didn't have any existing catalogs, so a new catalogs file has been created!");
            }
        }

        private void write(string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            foreach (String catalog in catalogs)
            {
                String output = catalog;

                writer.WriteLine(output);
            }

            writer.Close();
        }

        private void writeNew()
        {
            StreamWriter writer = new StreamWriter("Catalogs.txt");

            String[] exampleCatalogs =
            {
                "Cooking",
                "Camping",
                "Eating",
            };

            foreach (String catalog in exampleCatalogs)
            {
                String output = catalog;

                writer.WriteLine(output);
            }

            writer.Close();
        }

        private void clear()
        {
            catalogsBox.Items.Clear();
            catalogs.Clear();
        }

        private void read(string filename)
        {
            StreamReader reader = new StreamReader(filename);

            String input = reader.ReadLine();
            while (input != null)
            {
                catalogs.Add(input);
                catalogsBox.Items.Add(input);
                input = reader.ReadLine();
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            changeCounter++;
            if (catalogBox.Text == "")
            {
                MessageBox.Show("Enter a value for your catalog.");
                return;
            }

            catalogsBox.Items.Add(catalogBox.Text);
            catalogs.Add(catalogBox.Text);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            currentFileGlobalVarLol = openDialog.FileName;
            clear();
            read(currentFileGlobalVarLol);
            MessageBox.Show("File opened.");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            write(currentFileGlobalVarLol);
            changeCounter = 0;
        }

        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            if (changeCounter > 0)
            {
                if (MessageBox.Show("You have unsaved changes! Do you want to save your work?", "Mail Order 11", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    write(currentFileGlobalVarLol);
                }
            }
        }
    }
}
