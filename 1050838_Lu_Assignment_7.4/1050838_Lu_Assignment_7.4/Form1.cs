using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1050838_Lu_Assignment_7._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void printSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialogBagel.Document = printDocumentBagel;
            printPreviewDialogBagel.ShowDialog();
        }

        private void printDocumentBagel_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Times New Roman", 12);
            Font headingFont = new Font("Times New Roman", 12);

            float vertFloat = e.MarginBounds.Top;
            float horiFloat = e.MarginBounds.Left;
            float lineFloat = printFont.GetHeight();

            e.Graphics.DrawString("Programmed by Steven Lu",
                                 headingFont,
                                 Brushes.Red,
                                 horiFloat,
                                 vertFloat);

            vertFloat += 2 * lineFloat;

            e.Graphics.DrawString("Types: ",
                                  headingFont,
                                  Brushes.Red,
                                  horiFloat,
                                  vertFloat);

            vertFloat += 2 * lineFloat;

            foreach (String s in typeBox.Items)
            {
                e.Graphics.DrawString(s,
                                  headingFont,
                                  Brushes.Red,
                                  horiFloat,
                                  vertFloat);

                vertFloat += 2 * lineFloat;
            }
        }

        private void clearForNextCarterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            typeBox.Text = "";
        }

        private void addBagelTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String newBagel = typeBox.Text;
            bool isNewBagel = true;

            foreach (String yacht in typeBox.Items)
            {
                if (yacht == newBagel)
                {
                    isNewBagel = false;
                    break;
                }
                if (typeBox.Text == "")
                {
                    isNewBagel = false;
                    MessageBox.Show("Check input");
                    break;
                }
            }

            if (isNewBagel)
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
            numberBox.Text = typeBox.Items.Count.ToString();
        }
    }
}
