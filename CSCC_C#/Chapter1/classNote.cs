class DemoVariables
{
    static void Main()
    {
        int anInt = -123;
        uint anUnsignedInt = 567;

        Console.WriteLine("The int is {0} and the unsigned int is {1}", anInt, anUnsignedInt);

        Console.Read();

    }
}

////////////////////////////////////Operations ////////////////////////////////////
 int value1 = 43, value2 = 10, 
            sum, diff, product, quotient, remainder;

        sum = value1 + value2;
        diff = value1 - value2;
        quotient = value1 / value2;
        product = value1 * value2;
        remainder = value1 % value2;

        Console.WriteLine("The sum of {0} and {1} is {2}", value1, value2, sum);
        Console.WriteLine("The difference of {0} and {1} is {2}", value1, value2, diff);
        Console.WriteLine("The quotient of {0} and {1} is {2}", value1, value2, quotient);
        Console.WriteLine("The product of {0} and {1} is {2}", value1, value2, product);
        Console.WriteLine("The remainder of {0} and {1} is {2}", value1, value2, remainder);

        Console.Read();
		
/////////////////Boolean Comparison//////////////////////////////////////
static void Main()
    {
        int value = 4;
        bool isSixMore = 6 > value;
        Console.WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);

        value = 35;
        isSixMore = 6 > value;
        Console.WriteLine("When value is {0} isSixMore is {1}", value, isSixMore);

        Console.Read();
    }
	
////////////////////////////////////////Tab and Lines////////////////////////////////////////
  static void Main()
    {
        Console.WriteLine("This line \tcontains two \ttabs");
        Console.WriteLine("This statement \ncontains a new line");

        Console.Read();
    }
}
////////////////////////////////Constants ///////////////////////
static void Main()
    {
        const double PI = 3.1415;

        PI = 5;
        Console.WriteLine("This line \tcontains two \ttabs");
        Console.WriteLine("This statement \ncontains a new line");

        Console.Read();
    }

///////////////////////////// Request User for Input /////////////////////////////////////
  static void Main()
    {
        string name, firstString, secondString;
        int first, second, sum;

        //Prompt the user for name
        Console.Write("Enter your name...");
        name = Console.ReadLine();
        Console.Write("Hello {0}", name);
       
        //Prompt the userfor first intger and store in first
        Console.Write("Enter the first integer...");
        firstString = Console.ReadLine();
        first = Convert.ToInt32(firstString);

        //Prompt for second integer 
        Console.Write("Enter second integer...");
        secondString = Console.ReadLine();
        second = Convert.ToInt32(secondString);

        //Add the two integer and output result
        sum = first + second;
        Console.WriteLine("{0}, the sum of  of {1} and {2} is {3}", name , first, second, sum);
        Console.Read();
    }
}