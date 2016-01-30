using System;
public class ReverseArray
{
   public static void Main()
   {
      string[] names = {"Zach", "Rose", "Wendy", "Marcia"};
      int x;
      Array.Reverse(names);
      for(x = 0; x < names.Length; ++x)
         Console.WriteLine(names[x]);
   }
}
