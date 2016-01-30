using System;
public class PassEntireArray
{
   public static void Main()
   {
      int[] someNums = {10, 12, 22, 35};
      int x;
      Console.Write("\nAt beginning of Main() method...");
      for(x = 0; x < someNums.Length; ++x)
         Console.Write("{0, 6}", someNums[x]);
      Console.WriteLine();
      MethodGetsArray(someNums);
      Console.Write("At end of Main() method..........");
      for(x = 0; x < someNums.Length; ++x)
         Console.Write("{0, 6}", someNums[x]);
   }
   public static void MethodGetsArray(int[] vals)
   {
      int x;
      Console.Write("In MethodGetsArray() ");
      for(x = 0; x < vals.Length; ++x)
         Console.Write(" {0}", vals[x]);
      Console.WriteLine();
      for(x = 0; x < vals.Length; ++x)
         vals[x] = 888;
      Console.Write("After change");
      for(x = 0; x < vals.Length; ++x)
         Console.Write(" {0}", vals[x]);
      Console.WriteLine();
   }
}
