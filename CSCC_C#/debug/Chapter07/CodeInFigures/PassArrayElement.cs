using System;
public class PassArrayElement
{
   public static void Main()
   {
      int[] someNums = {10, 12, 22, 35};
      int x;
      Console.Write("\nAt beginning of Main() method...");
      for(x = 0; x < someNums.Length; ++x)
         Console.Write("{0,6}", someNums[x]);
      Console.WriteLine();
      for(x = 0; x < someNums.Length; ++x)
         MethodGetsOneInt(someNums[x]);
      Console.Write("At end of Main() method..........");
      for(x = 0; x < someNums.Length; ++x)
         Console.Write("{0,6}", someNums[x]);
   }
   public static void MethodGetsOneInt(int oneVal)
   {
      Console.Write("In MethodGetsOneInt() {0}", oneVal);
      oneVal = 999;
      Console.WriteLine("     After change {0}", oneVal);
   }
}
