using System;
public class SortArray
{
   public static void Main()
   {
      string[] names = {"Olive", "Patty",
         "Richard", "Ned", "Mindy"};
      int x;
      Array.Sort(names);
      for(x = 0; x < names.Length; ++x)
         Console.WriteLine(names[x]);
   }
}
