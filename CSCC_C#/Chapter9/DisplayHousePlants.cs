/**
 * Name: Chidi Emeh
 * Date: 11/6/2015
 * File Name: DisplayHousePlants.cs
 * Program: This program creates a class HousePlants
 *          with several fields and methods and then
 *          creates objects to test the features.
 * */

using System;

namespace Test
{
    class DisplayHousePlants
    {
        static void Main()
        {
            HousePlants outdoorPlant = new HousePlants("Rose", 12.99, true);
            HousePlants indoorPlant = new HousePlants("African Violet", 5.87, false);
            HousePlants shadyPlant = new HousePlants("Philodendron", 20.56, true);

            Console.WriteLine("The outdoor plant {0} is priced at {1:C}.", outdoorPlant.Name, outdoorPlant.Price);
            Console.WriteLine("         Last month feeding is {0}.", outdoorPlant.Fed.ToString());
            Console.WriteLine("The indoor plant {0} is priced at {1:C}.", indoorPlant.Name, indoorPlant.Price);
            Console.WriteLine("         Last month feeding is {0}.", indoorPlant.Fed.ToString());
            Console.WriteLine("The shady plant {0} is priced at {1:C}.", shadyPlant.Name, shadyPlant.Price);
            Console.WriteLine("         Last month feeding is {0}.", shadyPlant.Fed.ToString());
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.Read();
        }

    }

    class HousePlants
    {
        private string name;
        private double price;
        private bool fed;
     

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool Fed
        {
            get { return fed; }
            set { fed = value; }
        }

        public HousePlants (string nameGiven, double priceGiven, bool isFed)
        {
            name = nameGiven;
            price = priceGiven;
            fed = isFed;
        }
    }
}
