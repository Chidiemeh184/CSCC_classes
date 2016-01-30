/*
 * Name: Chidi Emeh
 * Title: Sum.cs
 * Date: 9/23/2015
 * Description: This program ask for an integer number
 *              and finds the sum and count while the
 *              input is not 999.
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Sum
    {
        static void Main(string[] args)
        {
            string userInput;
            int num, count = 0, sum = 0;

            Console.WriteLine("*** Addition of Integer Numbers ***");
            Console.WriteLine();
            Console.WriteLine("To stop this program, enter the value 999.");
            Console.Write("Enter an integer number: ");
            userInput = Console.ReadLine();
            num = Convert.ToInt32(userInput);

            while (num != 999)
            {
                sum = sum + num;
                count = count + 1;
             
                Console.Write("Enter an integer number: ");
                userInput = Console.ReadLine();
                num = Convert.ToInt32(userInput);
            }
            Console.WriteLine();
            Console.WriteLine("The sum of the number is: {0}", sum);
            Console.WriteLine("The number count is: {0}", count);
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();
        }
    }
}
