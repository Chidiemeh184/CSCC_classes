using System;
public class ParameterDemo2
{
   public static void Main()
   {
      int quantity = 4;
      Console.WriteLine("In Main quantity is {0}", quantity);
      DisplayReferenceParameter(ref quantity);  // notice use of ref
      Console.WriteLine("In Main quantity is {0}", quantity);
   }
   public static void DisplayReferenceParameter(ref int number)  
      // notice use of ref
   {
      number = 888;
      Console.WriteLine("In DisplayReferenceParameter(), number is {0}",
         number);
   }
}
