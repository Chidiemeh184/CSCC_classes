using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class SwitchCase
    {
        public static void Main()
        {
            string inputString;
            int testInteger;

            Console.Write("Enter an integer: ");
            inputString = Console.ReadLine();
            testInteger = Convert.ToInt32(inputString);

            switch (testInteger)
            {
                case 1: 
                    Console.WriteLine("You entered 1");
                    break;

                case 2:
                    Console.WriteLine("You entered 2");
                    break;
                case 3:
                    Console.WriteLine("You entered 3");
                    break;

                case 4:
                    Console.WriteLine("You entered 4");
                    break;

                case 5:
                    Console.WriteLine("You entered 5");
                    break;

                default:
                    Console.WriteLine("You did not enter a numvber between 1 and 5");
                    break;
            }
            bool lessThanTen = testInteger < 10 ? true : false;
            Console.WriteLine("The number is less 10 " + lessThanTen);
            Console.Read();
        }
    }
}
