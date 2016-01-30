using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Blender_Order_Form
{
    public partial class message : Form
    {
        public message()
        {
            InitializeComponent();
            errorLabel.Text = "Enter a valid number of blenders.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void message_Load(object sender, EventArgs e)
        {

        }
    }
}
