using System;
public class UseTaxMethod
{
   public static void Main()
   {
      double myPurchase = 12.99;
      DisplaySalesTax(myPurchase);
      DisplaySalesTax(35.67);
   }
   public static void DisplaySalesTax(double saleAmount)
   {
      double tax;
      const double RATE = 0.07;
      tax = saleAmount * RATE;
      Console.WriteLine("The tax on {0} is {1}",
         saleAmount.ToString("C"), tax.ToString("C"));
   }
}