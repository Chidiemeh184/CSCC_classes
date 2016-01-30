/**
 * Name :       Chidi Emeh
 * Date :       10/24/2015
 * Program:     Commission.cs
 * Description: This program calcultes the commission based 
 *              on the given sale, form the user.
 * 
 * */

using System;


class Commission
{
    static void Main()
    {
        double temp;
        Console.WriteLine("*** Commission Calculator***");
        DisplayPrompt();
        string userInput = Console.ReadLine();
        while(!userInput.Equals("-1"))
        {
            temp = CalculateCommission(ReadUserInput(userInput));
            double f = Convert.ToDouble(userInput);
            Console.WriteLine();
            Console.WriteLine("   The commission on sales of {0:C} is {1:C}.", f, temp);
            DisplayPrompt();
            userInput = Console.ReadLine();
        }
    }

    private static double ReadUserInput(string input)
    {
        double amount;
        amount = Convert.ToDouble(input);
        return amount;
    }

    private static double CalculateCommission(double input)
    {
        double commission = 0.00;
        const double LOW = 0.03;
        const double MID= 0.04;
        const double HIGH= 0.05;


        if (input > 0 &&  input <= 999 )
        {
            commission = input * LOW;
        }

        else if ( input < 3000 )
        {
            commission = input * MID;
       
        }

        else 
        {
            commission = input * HIGH;
        }
        return commission;
    }

    //Helper method to display prompt message
    private static void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Enter -1 to terminate the commission calculations.");
        Console.Write("Enter the daily sales (whole amount): ");
    }
}