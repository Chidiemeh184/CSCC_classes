using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DebugThree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private button1_Click(object sender, EventArgs e)
        {
            button1.visible = true;
            button2.visible = true;
        }

        private void button2_Clock(object sender, EventArgs e)
        {
            button2.visible = true;
            button1.visible = true;
        }
    }
}
