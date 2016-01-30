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
    public partial class magicBlenderForm : Form
    {

        String blender;
        double number, total, tax, sum;

        public magicBlenderForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderNowButton_Click(object sender, EventArgs e)
        {


            blender = blenderTextBox.Text;


            if (Double.TryParse(blender, out number))
            {


                if ((number == 0) || (number < 0))
                {
                    message error = new message();
                    error.ShowDialog();
                }

                else
                {
                    total = number * 39.95;
                    tax = total * 0.07;
                    sum = total + tax;

                    outputLabel.Text = "Receipt for: \n" + nameTextBox.Text
                     + "\n" + addressTextBox.Text
                     + "\n" + cityTextBox.Text + ", "
                     + stateTextBox.Text + " " + zipCodeTextBox.Text
                     + "\n" + blenderTextBox.Text + " blender(s)" + " ordered @$39.95 each"
                     + "\n" + " Total:  " + (string.Format("{0:c2}", total))
                     + "\n" + "  Tax:   " + (string.Format("{0:c2}", tax))
                     + "\n" + "--------------------------------"
                     + "\n" + " Due:  " + (string.Format("{0:c2}", sum));

                }
            }
            else
            {
                message error = new message();
                error.ShowDialog();
            }

        }

        private void blenderTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
