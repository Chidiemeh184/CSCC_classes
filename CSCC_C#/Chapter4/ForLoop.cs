using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ForLoop
    {
        static void Main()
        {
            const int LIMIT = 20;
            for (int x = 1; x < LIMIT; x++)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
