using System;
public class TotalPurchase
{
   public static void Main()
   {
      double purchase;
      double total = 0;
      string inputString;
      const double QUIT = 0;
      Console.WriteLine("Enter purchase amount ");
      inputString = Console.ReadLine();
      purchase = Convert.ToDouble(inputString);
      while(purchase != QUIT)
      {
         total += purchase;
         Console.WriteLine("Enter next purchase amount, or " +
            QUIT + " to quit ");
         inputString = Console.ReadLine();
         purchase = Convert.ToDouble(inputString);
      }
      Console.WriteLine("Your total is {0}", total.ToString("C"));
   }
}
