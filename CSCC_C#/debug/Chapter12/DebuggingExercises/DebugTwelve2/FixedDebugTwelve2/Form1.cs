using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {
                Form2 meetingForm = new Form2();
                meetingForm.ShowDialog();
                checkBox1.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckedChanged == true)
            {
                Form3 duesForm = new Form3();
                duesForm.ShowDialog();
                checkBox2.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked = true)
            {
                Form4 officersForm = new Form4();
                officersForm.ShowDialog();
                checkBox3.CheckState = CheckState.Unchecked;
            }
        }
    }
}
