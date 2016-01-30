using System;


class Comission
{
    static void Main()
    {
        double temp;
        string TERMINATE = "-1";
        Console.WriteLine("***Commission Calculator***");
        Console.WriteLine();

        Console.Write("Enter the daily sales (whole amount): ");
        string userInput = Console.ReadLine();
        while(userInput != TERMINATE)
        {
            temp = CalculateCommission(ReadUserInput(userInput));
            Console.WriteLine();
            Console.WriteLine("The commission on sales of {0:C} is {1:C}.", userInput, temp);
            Console.WriteLine();
            Console.Write("Enter the daily sales (whole amount): ");
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
        const double MID= 0.04;
        const double HIGH= 0.05;


        if (input > 0 && input <= 999 )
        {
            commission = input * 0.03;
        }

        if (input < 3000 )
        {
            commission = input * MID;
        }

        if ( input >= 3000)
        {
            commission = input * HIGH;
        }
        return commission;
    }
}