using System;
public class RentFinder
{
   public static void Main()
   {
      int[ , ] rents = { {400, 450, 510},
                         {500, 560, 630},
                         {625, 676, 740},
                         {1000, 1250, 1600} };
      int floor;
      int bedrooms;
      string inputString;
      Console.Write("Enter the floor on which you want to live ");
      inputString = Console.ReadLine();
      floor = Convert.ToInt32(inputString);
      Console.Write("Enter the number of bedrooms you need ");
      inputString = Console.ReadLine();
      bedrooms = Convert.ToInt32(inputString);
      Console.WriteLine("The rent is {0}",
         rents[floor, bedrooms]);
   }
}
