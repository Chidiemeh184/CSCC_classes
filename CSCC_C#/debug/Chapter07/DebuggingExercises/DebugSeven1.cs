// Uses DisplayWebAddress method three times
using System;
public class DebugSeven1
{
   public static void Main()
   {
      DisplayWebAddress();
      Console.WriteLine("Shop at Shopper's World");
      DisplayWebAddress(address);
      Console.WriteLine("The best bargains from around the world");
      DisplayWebAddress(address);
   }
   public static DisplayWebAddress()
   {
      Console.WriteLine("------------------------------");
      Console.WriteLine("Visit us on the web at:");
      Console.WriteLine("www.shoppersworldbargains.com");
      Console.WriteLine("******************************");
   }
}
