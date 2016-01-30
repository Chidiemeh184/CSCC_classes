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
            int input, egg1, egg2, egg3, egg4;

            Console.WriteLine("{0,-22} {1, 4}", "Enter the number of eggs laid by chicken number 1: ", egg1);
            input = Console.ReadLine();
            egg1 = Convert.ToInt32(input);
          
            Console.WriteLine("{0,-22} {1, 4}", "Enter the number of eggs laid by chicken number 1: ", egg2);
            input = Console.ReadLine();
            egg2 = Console.ReadLine();
            
            Console.WriteLine("{0,-22} {1, 4}", "Enter the number of eggs laid by chicken number 1: ", egg3);
            input = Console.ReadLine();
            egg3 = Console.ReadLine();

            Console.WriteLine("{0,-22} {1, 4}", "Enter the number of eggs laid by chicken number 1: ", egg4);
            input = Console.ReadLine();
            egg4 = Console.ReadLine();




            int sum = egg1 + egg2 + egg3 + egg4;
            int totalInDozen = sum / 12;
            int totalRemainder = sum % 12;

            Console.WriteLine("Sum of eggs is:{0} ", sum);
            Console.WriteLine("Sum of eggs in dozen: {0}", totalInDozen);
            Console.WriteLine("Sum of eggs remainder: {0} ", totalRemainder);
            Console.WriteLine("Thus there is {0} dozen and {1} eggs.", totalInDozen, totalRemainder);
            Console.Read();
        }
    }
}
