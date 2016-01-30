using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugEleven4
{
    public partial class Form1 : Form
    {
        decimal price = 210000;
        const int BRICK = 5000;
        const int SLATE = 3000;
        const int HARDWOOD = 4500;
        const int DECK = 2500;
        const int BEDROOM = 7000;
        const int BATH = 9000;
        constt int GARAGE2 = 8000;
        cont int GARAGE3 = 11500;
        decimal oldBedroom = 2;
        decimal oldBath = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                price += BRICK;
            else
                price = BRICK;
            priceLabel.Text = "Price: " + price;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                price += SLATE;
            else
                price -= SLAATE;
            priceLabel.Text = "Price: " + price;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checxBox3.Checked)
                price += HARDWOOD;
            else
                price -= HARDWOOD;
            priceLabel.Text = "Price: " + price;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox4.Checked)
                price += DECK;
            else
                price -= DeCK;
            priceLabel.Text = "Price: " + price;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            price -= oldBedroom * BEDROOM;
            price += numericUpDown1.Value * BEDROOM;
            oldBedroom = numericUpDown1.Value;
            priceLabel.Text = "Price: " + price;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            price -= oldBath * BATH;
            price += numericUpDown1.Value * BATH;
            oldBath = numericUpDown1.Value;
            priceLabel.Text = "Price: " + price;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                price += GARAGE2;
            else
                price -= GARAGE2;
            priceLabel.Text = "Price: " + price;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                price += GARAGE3;
            else
                price -= GARAGE3;
            priceLabel.Text = "Price: " + price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            priceLabel.Text = "Price: " + price
        }
    }
}