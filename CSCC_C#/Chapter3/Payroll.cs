/*
 * Name: Chidi Emeh
 * Title: Payroll.cs
 * Date: 9/23/2015
 * Description: This program calculates the 
 *              gross pay and tax withholdings 
 *              for an employee
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Payroll
    {
        public static void Main()
        {
            //Declare Variables
            string userInput;
            double payRate, hours, grossPay, tax = 0, netPay;

            
            //Display Header
            Console.WriteLine("*** Payroll Office ***");
            Console.WriteLine();

            
            //Request User for Input
            Console.Write("Enter hourly pay rate: ");
            userInput = Console.ReadLine();
            payRate = Convert.ToDouble(userInput);
            Console.Write("Enter hours worked: ");
            userInput = Console.ReadLine();
            hours = Convert.ToDouble(userInput);
            Console.WriteLine();
            
            //Calculations
            grossPay = payRate * hours;

            if (grossPay <= 300.00)
                tax = grossPay * 0.01;
            
            else
                if (grossPay >= 300.01)
                    tax = grossPay * 0.12;

            netPay = grossPay - tax;

           
            //Display Results
            Console.WriteLine("Gross pay:          {0:C}", grossPay);
            Console.WriteLine("Tax withholding:    {0:C}", tax);
            Console.WriteLine("Net pay:            {0:C}", netPay);
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
