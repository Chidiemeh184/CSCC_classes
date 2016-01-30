using System;
public class MovieDiscount
{
   public static void Main()
   {
      int age = 10;
      char rating = 'R';
      const int CHILD_AGE = 12;
      const int SENIOR_AGE = 65;
      Console.WriteLine("When age is {0} and rating is {1}",
         age, rating);
      if((age <= CHILD_AGE || age >= SENIOR_AGE) && rating == 'G')
         Console.WriteLine("Discount applies");
      else
         Console.WriteLine("Full price");
   }
}
