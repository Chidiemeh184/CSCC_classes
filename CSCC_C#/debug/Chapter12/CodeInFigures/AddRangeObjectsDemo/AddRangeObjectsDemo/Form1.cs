using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddRangeObjectsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmployee = (Employee)listBox1.SelectedItem;
            outputLabel.Text = selectedEmployee.LastName + "'s salary is " +
                selectedEmployee.Salary.ToString("C");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(new Employee[] { new Employee("Anderson", 25000),
                                                     new Employee("Brown", 36000),
                                                     new Employee("Crenshaw", 45000) });
        }
    }
    class Employee
    {
        public string LastName { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name,  double sal)
        {
               LastName = name;
               Salary = sal;
        }
        public override string ToString()
        {
            return LastName;
        }
    }
}
