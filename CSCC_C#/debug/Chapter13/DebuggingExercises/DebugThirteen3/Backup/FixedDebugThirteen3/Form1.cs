using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve3
{
    public partial class Form1 : Form
    {
        private string sentence = "";
        private bool s1 = false;
        private bool s2 = false;
        private bool s3 = false;
        private bool s4 = false;
        private bool s5 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (s1 && s2 && s3 && s4 && s5)
            {
                sentence = comboBox1.SelectedItem + " " +
                  comboBox2.SelectedItem + " " +
                  comboBox3.SelectedItem + " " +
                  comboBox4.SelectedItem + " " +
                  comboBox5.SelectedItem + ".";
                label2.Text = sentence;
            }
            else
                label2.Text = "You did not make all the required selections.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s1 = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            s3 = true;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            s4 = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            s5 = true;
        }
    }
}