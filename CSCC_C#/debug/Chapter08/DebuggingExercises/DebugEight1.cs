// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is #3.99 each
using System;
public class DebugEight1
{
   public static void Main()
   {
      int orderNum, quantity;
      double total;
      const double PRICE_EACH = 3.99;
      GetData(orderNum, quantity);
      total = quantity * PRICE_EACH;
      Console.WriteLine("Order #{0}. Quantity ordered = {1}",
          ordernum, quanity);
      Console.WriteLine("Total is {0}", total.ToString("C));
   }
   public void GetData(out order, out amount)
   {
       String s1, s2;
       Console.Write("Enter order number ");
       Console.Write("Enter quantity ");
       order = Convert.ToInt32(s1);
       amount = Convert.ToInt32(s2);
       return order, amount;
   }
}

