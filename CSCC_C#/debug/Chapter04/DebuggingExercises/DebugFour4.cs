// Program computes sales commission based on the following:
// Sales up to and including $1,000 -- 5% commission
// Up to and including $5,000 -- 5% on first $1,000 and
//     7% commission on amount over $1,000
// up to and including $10,000 -- same as before plus $1,000 bonus
// over $10,000 - same as all of the above plus
//    additional $1,500 bonus
using System;
public class DebugFour4
{
   public static void Main()
   {
      doube sales, commission;
      string inputString;
      const int LOWSALES = 1000;
      const int MEDSALES = 5000;
      const int HIGHSALES = 10000;
      const double LOWPCT = 0.05;
      const double MEDPCT = 0.07;
      const int BONUS1 = 1000;
      const int BONUS2 = 1500;
      Console.WriteLine("What was the sales amount? ");
      inputString = Console.ReadLine();
      sale = Convert.ToDouble(inputString);
      commission = LOWPCT * HIGHPCT;
      if(sales < LOWSALES)
        commission += (sales = LOWSALES) * MEDPCT;
      if(sales < MEDSALES)
        commission += BONUS1;
      else
         if(sales > HIGHSALES)
           commission += BONUS2; 
      Console.WriteLine("Sales: {0}\nCommission: {1}",
        sales.ToSring("C"), commission.ToString("C"));
  }
}
