using System;
public class PriceListApplication3
{
   public static void Main()
   {
      int item;
      try
      {
         Console.Write("Enter an item number >> ");
         item = Convert.ToInt32(Console.ReadLine());
         PriceList.DisplayPrice(item);
      }
      catch(Exception e)
      {
         Console.WriteLine(e.StackTrace);
      }
   }
}
class PriceList
{
   private static double[] price = {15.99, 27.88, 34.56, 45.89};
   public static void DisplayPrice(int item)
   {
      double tax;
      double total;
      double pr;
      pr = price[item];
      tax = pr * Tax.DetermineTaxRate(pr);
      total =  pr + tax;
      Console.WriteLine("The total price is " +
         total.ToString("C"));
   }
}
public class Tax
{
   private static double[] taxRate = {0.06, 0.07};
   private static double CUTOFF = 20.00;
   public static double DetermineTaxRate(double price)
   {
      int subscript;
      double rate;
      if(price <= CUTOFF)
         subscript = 0;
      else
         subscript = 2;
      rate = taxRate[subscript];
      return rate;
   }
}
