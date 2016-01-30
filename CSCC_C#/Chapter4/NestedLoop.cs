using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TippingTable
    {
        static void Main()
        {
            double dinnerPrice = 10.00;
            double tipRate;
            double tip;

            const double LOWRATE = 0.10;
            const double MAXRATE = 0.25;
            const double TIPSTEP = 0.05;
            const double MAXDINNER = 100.00;
            const double DINNERSTEP = 10.00;

            Console.Write("Price");
            for (tipRate = LOWRATE; tipRate <= MAXRATE; tipRate += TIPSTEP)
                Console.Write("{0, 8}", tipRate.ToString("F"));
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");


            tipRate = LOWRATE;

            while (dinnerPrice <= MAXDINNER)
            {
                Console.Write("{0, 8}", dinnerPrice.ToString("C"));
                while (tipRate <= MAXRATE)
                {
                    tip = dinnerPrice * tipRate;
                    Console.Write("{0, 8}", tip.ToString("F"));
                    tipRate += TIPSTEP;
                }

                dinnerPrice += DINNERSTEP;
                tipRate = LOWRATE;
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
