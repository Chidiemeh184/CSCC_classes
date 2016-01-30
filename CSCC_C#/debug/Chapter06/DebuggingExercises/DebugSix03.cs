// Finds whether a book dealer carries a requested book
using System;
public class DebugSix03
{
   public static void Main()
   {
      String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
      int x;
      string entryString;
      Console.Write("What book are you looking for? ");
      entryString = Console.Readlne();
      x = BinarySearch(entryString);
      if(x < 0)
         Console.WriteLine("{0} not found", entryString);
      else
         Console.WriteLine("Yes, we carry {0}", entryString);   
   }
}
