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

namespace _1050838_Lu_11._2
{
    public partial class Form1 : Form
    {

        List<Employee> Employees = new List<Employee>();
        public Form1()
        {
            InitializeComponent();

            try { read(); } catch { }
        }

        private void read()
        {
            StreamReader sr = new StreamReader("Employees.txt");

            String input = sr.ReadLine();
            while (input != null)
            {
                String[] employeeData = input.Split(',');
                Employee newEmployee = new Employee(employeeData[0], int.Parse(employeeData[1]), float.Parse(employeeData[2]));

                Employees.Add(newEmployee);

                employeesBox.Items.Add(newEmployee.Name);
                input = sr.ReadLine();
            }
            sr.Close();
        }

        private void write()
        {
            StreamWriter sw = new StreamWriter("Employees.txt");

            foreach (Employee emp in Employees)
            {
                String csvout = emp.Name + "," + emp.Phone.ToString() + "," + emp.Rate.ToString();

                sw.WriteLine(csvout);
            }

            sw.Close();
        }


        private void addButton_Click(object sender, EventArgs e)
        {


            Employee emp = new Employee(nameBox.Text, int.Parse(phoneBox.Text), float.Parse(rateBox.Text));
            Employees.Add(emp);
            employeesBox.Items.Add(nameBox.Text);
            write();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Employee selectedEmployee = Employees[employeesBox.SelectedIndex];
                payBox.Text = '$' + selectedEmployee.CalculatePay(int.Parse(hoursBox.Text)).ToString();
            } catch
            {
                MessageBox.Show("Please select a valid employee");
            }
        }

        private void employeesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = Employees[employeesBox.SelectedIndex];

            nameBox.Text = emp.Name;
            phoneBox.Text = emp.Phone.ToString();
            rateBox.Text = emp.Rate.ToString();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Calculate_Pay()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
