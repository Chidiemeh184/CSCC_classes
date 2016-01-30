// Program averages four numbers
using System;
public class DebugSix02
{
   public static void Main()
   {
      int[4] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total;
      Console.Write("\nThe numbers are...");
      for(x = 0; x < numbers; ++x)
         Console.Write("{0, 6}", numbers[x]);
      Console.WriteLine();      
      for(x = 0; x < numbers; ++x)
      {
         total += numbers[x];
      }   
      average = total / numbers.Length;
      Console.Write("The average is {0}", avg);
   }
}