using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double num1;
            double num1;
            double product;
            num1 = Convert.Double(textBox1.Text);
            num2 = Convert.Double(textBox2.Text);
            product = num1 * num2;
            outputLable.Text = String.Format("{0} times {1} is {2}", num1, num2, product);
        }
    }
}
