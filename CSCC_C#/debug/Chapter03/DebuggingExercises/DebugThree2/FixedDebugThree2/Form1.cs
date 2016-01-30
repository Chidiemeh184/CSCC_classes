using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private helloButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, " + textBox1.Text + "!";
        }

        private goodbyeButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Goodbye, " + textBox1.Text + "!";
        }
    }
}
