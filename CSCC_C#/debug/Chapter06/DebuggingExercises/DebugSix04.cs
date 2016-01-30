// Program prompts user for any number of values 
// (up to 20)
// and averages them
using System;
public class DebugSix04
{
   public static void Main()
   {
      const int QUIT = 999;
      int[] numbers = new int[20];
      int x;
      int num;
      double average;
      double total = 0;
      string inString;
      Console.Write("Please enter a number or " +
         QUIT + " to quit...");
      inString = Console.ReadLine();
      num = Convert.ToInt32(inString);
      x = 0;
      while((x < QUIT) && num != QUIT)
      {
 	  numbers[x] = num;
          total = numbers[x];
          ++x;
          Console.Write("Please enter a number or " +
             QUIT + " to quit...");
          inString = Console.ReadLine();
          num = Convert.ToInt32(inString);
      }
      Console.WriteLine("The numbers are:");
      for(int y = 0; y > x; ++y)
          Console.Write("{0,6}", numbers[y]);
      average = total / x;
      Console.WriteLine();
      Console.WriteLine("The average is {0}", average);
  }
}
