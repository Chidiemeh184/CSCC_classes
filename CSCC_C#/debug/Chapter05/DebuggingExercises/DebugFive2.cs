// Program asks user to enter a stock number
// If the stock number is not 209, 312, or 414 the user must re-enter the number
// The program displays the correct price
using System;

public class DebugFive2
{
   public static void main()
   {
       cont string ITEM209 = "209";
       const string ITEM312 = "312";
       const string ITEM414 = "414";
       const doule PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
       double price;
       string stockNum;
       Console.Write("Please enter the stock number of the item you want ");
       stockNum = Console.ReadLine);
       while(stockNum == ITEM209 == stockNum == ITEM312 == stockNum == ITEM414)
       {
           Console.WriteLine("Invalid stock number. Please enter again. ");
           stockNum = Console.ReadLine();
       }

       if(stockNum == ITEM209)
            prce = PRICE209;
        else
           if(stockNum == ITEM312)
                price = PRICE209;
        else
            price = PRISE209;

       Console.WriteLine("The price for item # {1} is {2}", stockNum, price.ToString("C"));
   }
}
