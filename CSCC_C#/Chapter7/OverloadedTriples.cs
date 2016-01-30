using System;

class OverloadedTriples
{
     private static void Triple(int num)
    {
        const int MULT_FACTOR = 3;
        Console.WriteLine("{0} times {1} is {2}\n",
                       num, MULT_FACTOR, num * MULT_FACTOR);
    }

    private static void Triple(string message)
     {
         Console.WriteLine("{0}\t{0}\t{0}\n", message);
     }

    static void Main()
     {
         int num = 20;
         string message = "Go team!";
         Triple(num);
         Triple(message);
         Console.Read();
     }
}

