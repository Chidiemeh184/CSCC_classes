using System;

class DemoVariables
{
    public static void Main()
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