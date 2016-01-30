using System;
public class ParameterDemo1
{
   public static void Main()
   {
      int quantity = 4;
      Console.WriteLine("In Main quantity is {0}", quantity);
      DisplayValueParameter(quantity);
      Console.WriteLine("In Main quantity is {0}", quantity);
   }
   public static void DisplayValueParameter(int quantity)
   {
      quantity = 777;
      Console.WriteLine("In DisplayValueParameter(), quantity is {0}", quantity);
   }
}
