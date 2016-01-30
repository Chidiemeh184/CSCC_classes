using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugTwelve4
{
    public partial class Form1 : Form
    {
        const int MIN = 0;
        const int MAX = 4;
        int[] order = new int[4];
        int[] usersOrder = new int[4];
        int buttonClicks = 0;
        bool allOkay = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            int randomNumber;
            bool isMatch = false;
            for (int x = 0; x < order.Length; ++x)
            {
                randomNumber = RandomClass.Next(MIN, MAX);
                order[x] = randomNumber;
                isMatch = false;
                for (int y = 0; y < x; ++y)
                    if (order[x] == order[y])
                        isMatch = true;
                if (isMatch)
                    --x;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usersOrder[buttonClicks] = 0;
            ++buttonClicks;
            if(buttonClicks == order.Length)
                determineWinner();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersOrder[buttonClicks] = 1;
            ++buttonClicks;
            if(buttonClicks == order.Length)
                determineWinner();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            usersOrder[buttonClicks] = 2;
            ++buttonClicks;
            if(buttonClicks == order.Length)
                determineWinner();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            usersOrder[buttonClicks] = 3;
            ++buttonClicks;
            if(buttonClicks == order.Length)
                determineWinner();
        }
        private void determineWinner()
        {
            string winningSequence = "";
            allOkay = true;
            for(int x = 0; x < order.Length; ++x)
            {
                if(order[x] != usersOrder[x])
                    allOkay = false;
            }
            for(int y = 0; y < order.Length; ++y)
                winningSequence += (order[y] + 1) + " ";
            if (allOkay)
            {
                label2.Text = "You win!";
                this.BackColor = Color.Chartreuse;
            }
            else
                label2.Text = "Sorry - you lose.";
            label2.Text += "\nSequence was " + winningSequence;

        }
    }
}