using System;
public class MilesPerGallon2
{
   public static void Main()
   {
      int milesDriven;
      int gallonsOfGas;
      int mpg;
      try
      {
         Console.Write("Enter miles driven ");
         milesDriven = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter gallons of gas purchased ");
         gallonsOfGas = Convert.ToInt32(Console.ReadLine());
         mpg = milesDriven / gallonsOfGas;
      }
      catch(Exception e)
      {
         mpg = 0;
         Console.WriteLine("You attempted to divide by zero!");
      }
      Console.WriteLine("You got {0} miles per gallon", mpg);
   }
}
