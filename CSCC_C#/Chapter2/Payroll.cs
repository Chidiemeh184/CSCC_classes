using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Payroll
    {
        public static void Main()
        {
            //Declaring Variables
            string name, input;
            int socialSecurity;
            double payRate, hoursWorked;
            double grossPay, federalWithholding, stateWithholding, netPay, tax;

            
            //Request User Information
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Social Security number: ");
            input = Console.ReadLine();
            socialSecurity = Convert.ToInt32(input);

            Console.Write("Hourly pay rate: ");
            input = Console.ReadLine();
            payRate = Convert.ToDouble(input); 

            Console.Write("Hours worked: ");
            input = Console.ReadLine();
            hoursWorked = Convert.ToDouble(input);
            Console.WriteLine();

            //Perform Calculations
            grossPay = payRate * hoursWorked;
            federalWithholding = 0.15 * grossPay;
            stateWithholding = 0.05 * grossPay;
            tax = stateWithholding + federalWithholding;
            netPay = grossPay - tax;

            //Display Results
            Console.WriteLine("Payroll Summary for: {0}", name);
            Console.WriteLine("SSN: {0}", socialSecurity);
            Console.WriteLine("You worked {0} hours at {1} per hour", hoursWorked, payRate.ToString("C2") );
            Console.WriteLine();
            Console.WriteLine("{0, -25}{1, 8}", "Gross pay: ", grossPay.ToString("C2"));
            Console.WriteLine("{0, -26}{1, 8}", "Federal withholding: ", federalWithholding.ToString("C2"));
            Console.WriteLine("{0, -26}{1, 8}", "State withholding:  ", stateWithholding.ToString("C2"));
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("{0, -25}{1, 8}", "Net pay: ", netPay.ToString("C2"));

            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();
        }
    }
}
