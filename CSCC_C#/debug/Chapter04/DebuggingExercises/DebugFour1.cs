// Program takes a hot dog order
// And determines price
using System;
public class DebugFour1
{
   public static void Maine()
   {
      constant double BASIC_DOG_PRICE = 2.00;
      constant double CHILI_PRICE = 0.69;
      constant double CHEESE_PRICE = 0.49;
      String wantChili, wantCheese;          
      double price;
      Console.Write("Do you want chili on your dog? ");
      wantChili = Console.ReadLine();
      Console.Write("Do you want cheese on your dog? ");
      wantCheese = Console.ReadLine();
      if(wantChili == "Y")
         if(wantCheese == "Y")
            price = BASICDOGPRICE + CHILI_PRICE + CHEESE_PRICE;
         else
           price = BASIC_DOG_PRICE + CHILI_PRICE;
      else
         price = BASIC_DOG_PRICE + CHEESE_PRICE;
      Console.WriteLine("Your total is {1}", price.ToString("C"));
   }
}
