using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_Unit_7_Xtreme_Cinema
{
    public partial class Form1 : Form
    {

        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void printSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogCategories.Document = printDocumentCategories;
            printPreviewDialogCategories.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearForNextCarterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryBox.Text = "";
        }

        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String newCategory = categoryBox.Text;
            bool checkCategory = true;

            foreach (String catalog in categoryBox.Items)
            {
                if (catalog == newCategory)
                {
                    checkCategory = false;
                    break;
                }
                if (categoryBox.Text == "")
                {
                    checkCategory = false;
                    MessageBox.Show("Check input");
                    break;
                }
            }

            if (checkCategory)
            {
                categoryBox.Items.Add(categoryBox.Text);
            }
            count++;
        }

        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                categoryBox.Items.RemoveAt(categoryBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Check input");
            }
        }

        private void displayCountOfBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countBox.Text = categoryBox.Items.Count.ToString();
        }

        private void printDocumentStyle_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 12);
            Font headingFont = new Font("Times New Roman", 12);

            float vertFloat = e.MarginBounds.Top;
            float horiFloat = e.MarginBounds.Left;
            float lineFloat = printFont.GetHeight();

            e.Graphics.DrawString("Steven Lu",
                                 headingFont,
                                 Brushes.Red,
                                 horiFloat,
                                 vertFloat);

            vertFloat += 2 * lineFloat;

            e.Graphics.DrawString("Categories: ",
                                  headingFont,
                                  Brushes.Red,
                                  horiFloat,
                                  vertFloat);

            vertFloat += 2 * lineFloat;

            foreach (String s in categoryBox.Items)
            {
                e.Graphics.DrawString(s,
                                  headingFont,
                                  Brushes.Red,
                                  horiFloat,
                                  vertFloat);

                vertFloat += 2 * lineFloat;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
