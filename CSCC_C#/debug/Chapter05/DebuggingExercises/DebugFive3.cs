// Program displays every possible ID number for a company
// ID number is a letter, followed by a two-digit number
// For example -- A00 or Z99
// Go to a new display line after every 20 IDs
using System;
public class DebugFive3
{
   public static void Main()
   {
      char letter;
      int number;
      const int LOW = 0;
      const int HIGH = 99;
      const int NUMINROW = 20;
      for(letter = 'A', letter <= 'B', ++letter)
        for(number = LOW; number <= HIGH; ++letter)
        {
          if(number % NUMINROW == 0)
            Console.WriteLine();
          Console.Write("{0}{1} ", letter, number.Tostring("D2"));
        }
   }
}
