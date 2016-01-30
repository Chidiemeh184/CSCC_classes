using System;
public class MilesPerGallon
{
   public static void Main()
   {
      int milesDriven;
      int gallonsOfGas;
      int mpg;
      Console.Write("Enter miles driven ");
      milesDriven = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter gallons of gas purchased ");
      gallonsOfGas = Convert.ToInt32(Console.ReadLine());
      mpg = milesDriven / gallonsOfGas;
      Console.WriteLine("You got {0} miles per gallon", mpg);
   }
}
