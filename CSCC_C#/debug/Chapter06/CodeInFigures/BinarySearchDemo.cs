using System;
public class BinarySearchDemo
{
   public static void Main()
   {
      int[] idNumbers = {122, 167, 204, 219, 345};
      int x;
      string entryString;
      int entryId;
      Console.Write("Enter an Employee ID ");
      entryString = Console.ReadLine();
      entryId = Convert.ToInt32(entryString);
      x = Array.BinarySearch(idNumbers, entryId);
      if(x < 0)
         Console.WriteLine("ID {0} not found", entryId);
      else
         Console.WriteLine("ID {0} found at position {1} ", 
            entryId, x);
   }
}
