using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve3
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Checked(object);
        }
        private void Checked(object sender)
        {
            CheckBox box = new CheckBox();
            box = (CheckBox)sender;
            if (box.Checked = true)
                ++count++;
            else --count;
            outputLabel.Text = "Item count is " + count;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender)
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checked(sender);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Checkeded(sender);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Checked(sender);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
            Checked(sender);
    }
}
