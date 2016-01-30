using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MajorListDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void majorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            majorLabel.Text = "You selected " + majorListBox.SelectedItem;
        }
    }
}
