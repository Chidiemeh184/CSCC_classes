using System;
public class PriceListApplication2
{
   public static void Main()
   {
      int item = 0;
      bool isGoodItem = false;
      while(!isGoodItem)
      {
         try
         {
            Console.Write("Enter an item number >> ");
            item = Convert.ToInt32(Console.ReadLine());
            PriceList.DisplayPrice(item);
            isGoodItem = true;
         }
         catch(IndexOutOfRangeException e)
         {
            Console.WriteLine("You must enter a number less " +
               "than 4");
            Console.WriteLine("Please reenter item number ");
         }
      }
      Console.WriteLine("Thank you");
   }
}

class PriceList
{
   private static double[] price = {15.99, 27.88, 34.56, 45.89};
   public static void DisplayPrice(int item)
   {
      Console.WriteLine("The price is " +
         price[item].ToString("C"));
   }
}
