using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Egg
    {
        public static void Main()
        {
            string input;
            int egg1, egg2, egg3, egg4;

            Console.Write("{0, 4}", "Enter the number of eggs laid by chicken number 1: ");
            input = Console.ReadLine();
            egg1 = Convert.ToInt32(input);

            Console.Write("{0, 4}", "Enter the number of eggs laid by chicken number 2: ");
            input = Console.ReadLine();
            egg2 = Convert.ToInt32(input);

            Console.Write("{0, 4}", "Enter the number of eggs laid by chicken number 3: ");
            input = Console.ReadLine();
            egg3 = Convert.ToInt32(input);

            Console.Write("{0, 4}", "Enter the number of eggs laid by chicken number 4: ");
            input = Console.ReadLine();
            egg4 = Convert.ToInt32(input);
            Console.WriteLine();
            Console.WriteLine();


            int sum = egg1 + egg2 + egg3 + egg4;
            int totalInDozen = sum / 12;
            int totalRemainder = sum % 12;

            //Console.WriteLine("Sum of eggs is:{0} ", sum);
            //Console.WriteLine("Sum of eggs in dozen: {0}", totalInDozen);
            //Console.WriteLine("Sum of eggs remainder: {0} ", totalRemainder);
            //Console.WriteLine("Thus there is {0} dozen and {1} eggs.", totalInDozen, totalRemainder);
            
            Console.WriteLine("This month the  chicken laid {0} dozens and {1} eggs.", totalInDozen, totalRemainder);
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();
        }
    }
}
