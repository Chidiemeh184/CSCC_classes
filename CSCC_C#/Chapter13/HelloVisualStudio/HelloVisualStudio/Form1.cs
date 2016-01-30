using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloVisualStudio
{
    public partial class HelloName : Form
    {
        public HelloName()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (helloLabel.Visible)
                helloLabel.Visible = false;
            else
                helloLabel.Visible = true;

            changeOutputButton.Enabled = true;
           helloLabel.Text = inputTextbox.Text;
            //helloLabel.Visible = true;
        }

        private void changeOutputButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = "Goodbye";
        }
    }
}
