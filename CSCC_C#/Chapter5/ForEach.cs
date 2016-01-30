using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class ForEach
    {
        public static void Main()
        {
            double[] payRate = { 6.00, 7.35, 8.12, 12.45 };

            foreach (double item in payRate)
            {
                Console.WriteLine("Pay rate is {0}", item.ToString("C"));
            }
            Console.Read();
        }
    }
}
