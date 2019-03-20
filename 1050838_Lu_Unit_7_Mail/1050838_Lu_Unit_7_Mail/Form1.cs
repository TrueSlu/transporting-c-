using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_Unit_7_Mail
{
    public partial class Form1 : Form
    {

        /*
         * 
         * 
         * Steven Lu
         * 
         * 3/15/19
         * 
         */

        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void printSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogCatalog.Document = docCata;
            printPreviewDialogCatalog.ShowDialog();
        }

        private void clearForNextCarterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeBox.Text = "";
        }

        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String newCatalog = typeBox.Text;
            bool newCheck = true;

            foreach (String catalog in typeBox.Items)
            {
                if (catalog == newCatalog)
                {
                    newCheck = false;
                    break;
                }
                if (typeBox.Text == "")
                {
                    newCheck = false;
                    MessageBox.Show("Check your input");
                    break;
                }
            }

            if (newCheck)
            {
                typeBox.Items.Add(typeBox.Text);
            }
            count++;
        }

        private void removeBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                typeBox.Items.RemoveAt(typeBox.SelectedIndex);
            }
            catch
            {
                MessageBox.Show("Check input");
            }
        }

        private void displayCountOfBagelTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countBox.Text = typeBox.Items.Count.ToString();
        }

        private void printDocumentCatalog_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 12);
            Font headingFont = new Font("Times New Roman", 12);

            float vertFloat = e.MarginBounds.Top;
            float horiFloat = e.MarginBounds.Left;
            float lineFloat = printFont.GetHeight();

            e.Graphics.DrawString("Programmed By Steven Lu",
                                 headingFont,
                                 Brushes.Black,
                                 horiFloat,
                                 vertFloat);

            vertFloat += 2 * lineFloat;

            e.Graphics.DrawString("Types: ",
                                  headingFont,
                                  Brushes.Black,
                                  horiFloat,
                                  vertFloat);

            vertFloat += 2 * lineFloat;

            foreach (String s in typeBox.Items)
            {
                e.Graphics.DrawString(s,
                                  headingFont,
                                  Brushes.Blue,
                                  horiFloat,
                                  vertFloat);

                vertFloat += 2 * lineFloat;
            }
        }
    }
}
