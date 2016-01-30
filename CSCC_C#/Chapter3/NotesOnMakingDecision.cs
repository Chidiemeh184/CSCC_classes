//MAKING DECISIONS


/*

**/
 class CompareThreeNumbers
    {
        public static void Main()
        {
            string numberString;
            int num1, num2, num3;

            Console.Write("Enter an integer: ");
            numberString = Console.ReadLine();
            num1 = Convert.ToInt32(numberString);

            Console.Write("Enter an integer: ");
            numberString = Console.ReadLine();
            num2 = Convert.ToInt32(numberString);

            Console.Write("Enter an integer: ");
            numberString = Console.ReadLine();
            num3 = Convert.ToInt32(numberString);
			
			
            if (num1 == num2)
                if (num1 == num3)
                    Console.WriteLine("All three numbers are equal");

                else
                    Console.WriteLine("The First two are equal");

            else
                if (num1 == num3)
                    Console.WriteLine("Last two are equal");

                else
                    if (num2 == num3)
                        Console.WriteLine("Last two are equal");
                    else
                        Console.WriteLine("No two numbers are equal");

        }
    
	}
	
	
	//////////////////////////////AND and OR ////////////
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
		
		
		
		
		
	///////////////////////////SwitchCase Example //////////////
	
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
            Console.WriteLine("The number is less 10" + lessThanTen);
        }
    }
	
	
	///////////////////////////