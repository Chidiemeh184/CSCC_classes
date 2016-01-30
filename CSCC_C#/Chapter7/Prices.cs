/**
 * Name: Chidi Emeh
 * 
 * Date: 10/22/2013
 * 
 * Program: Prices.cs
 * 
 * Description: This program creates an array of 20 elements,
 *              and performs basic arithmetic. Then shows the
 *              numbers that are less than 5, sum, average and
 *              numbers greater than the average.
 * 
 * */
using System;

class Prices
{

    public static void Main()
    {
        double[] prices = new double[20];
        string userInput;
        int i=0, count = 0;
        double sum = 0.00, average;
        const int FIVE = 5;


        Console.WriteLine("In any order, enter 20 price values.");
        for (i = 0; i < 20; ++i)
        {
            Console.Write("Enter price {0}: ", i + 1);
            userInput = Console.ReadLine();
            prices[i] = Convert.ToDouble(userInput);
            ++count;
            sum = sum + prices[i];
        }
        Console.WriteLine();
        Console.WriteLine("The sum of values is: {0:C}.", sum);
        Console.WriteLine();


        Console.WriteLine("List of prices less than $5.00.");
        foreach (double item in prices)
            if (item < FIVE)
                Console.WriteLine("{0:C}", item.ToString("C"));
        Console.WriteLine();

        average = sum / count;

        Console.WriteLine("The price average is: {0:C}.", average);
        Console.WriteLine();

        Console.WriteLine("List of prices higher than the average: ");
        foreach (double num in prices)
            if (num > average)
                Console.WriteLine("{0:C}", num);

        Console.WriteLine();
        Console.WriteLine("Press the <Enter> key to terminate this program.");
        Console.Read();

    }
}

