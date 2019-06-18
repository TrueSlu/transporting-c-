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


namespace _1050838_Lu_11._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        bool changed = false;
        string currentFilename = "newEssay.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            textBox.Text = File.ReadAllText(openDialog.FileName);
            changed = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changed = false;
            saveDialog.ShowDialog();
            File.WriteAllText(saveDialog.FileName, textBox.Text);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changed)
            {
                if (MessageBox.Show("You have unsaved changes! Do you want to save your work?", "Text Editor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    saveDialog.ShowDialog();
                    File.WriteAllText(saveDialog.FileName, textBox.Text);
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }
    }
}
