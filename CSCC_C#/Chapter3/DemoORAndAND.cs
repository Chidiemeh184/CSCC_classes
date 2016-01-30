using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class DemoORAndAND
    {
        static void Main()
        {
            const int ZONE1 = 1, zone2 = 2;
            const int LOW_QUANTITY = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            Console.WriteLine("Delivery is free for zone {0} or {1}",
                ZONE1, zone2);
            Console.WriteLine("When the number of boxes is less than {0}", 
                LOW_QUANTITY);
            Console.WriteLine("Enter the Delivery Zone");
                inputString = Console.ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Console.WriteLine("Enter the number of boxes in the shipment");
            inputString = Console.ReadLine();
            quantity = Convert.ToInt32(inputString);

            if ((deliveryZone == ZONE1 || deliveryZone == zone2) && quantity < LOW_QUANTITY)
                Console.WriteLine("Delivery is free");

            else
                Console.WriteLine("A Delivery charge applies");

            Console.Read();
        }
    }
}
