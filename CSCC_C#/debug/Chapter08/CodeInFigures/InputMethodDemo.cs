using System;
public class InputMethodDemo
{
   public static void Main()
   {
      int first, second;
      InputMethod(out first, out second); // notice use of out
      Console.WriteLine("After InputMethod first is {0}", first);
      Console.WriteLine("and second is {0}", second);
   }
   public static void InputMethod(out int one, out int two) 
      // notice use of out
   {
      string s1, s2;
      Console.Write("Enter first integer ");
      s1 = Console.ReadLine();
      Console.Write("Enter second integer ");
      s2 = Console.ReadLine();
      one = Convert.ToInt32(s1);
      two = Convert.ToInt32(s2);
   }
}
