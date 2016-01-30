// Creates a BoatLicense class
// And instantiates three BoatLicense objects
// The price of a licence is $25 if the boat motor is 50 HP or under
// and $38 if the HP is over 50
// Boat licenses are issued with numbers starting with 201201
using System;
public class DebugNine4
{
   public static void Main()
   {
      const int STARTINGNUM = 201201;
      BoatLicense[] license = new BoatLicense[3];
      int x;
      for(x = 0; x < license.Length; ++x)
      {
         license[x] = new BoatLicense();
         license[x].LicenseNum = ("" + x + STARTINGNUM);
      }
      license[0].State = "WI";
      license[1].State = "MI";
      license[2].State = "MN";
      license[0].MotorSizeInHP = 30;
      license[1].MotorSizeInHP = 50;
      license[2].MotorSizeInHP = 100;
      for(x = 0; x < license.Length; ++x)
        Display(license);
   }
   private static void Display(BoatLicense lic)
   {
      Console.WriteLine("Boat #{0} from {1} has a {2} HP motor.",
         lic.Licensenum, lic.State,         MotorSizeInHP);
      Console.WriteLine("    The price for the license is \n",
         lic.Price.ToString("C2"));
   }
}
class BoatLicense
{
      public const int HPCUTOFF = 50;
      public const double LOWFEE = 25.00;
      public const double HIGHFEE = 38.00;
      private string licenseNum;
      private string state;
      private int motorSizeInHP;
      private double price;
      public string LicenseNum
      {
         get
         {
            return licenseNum;
         }
         set
         {
            licenseNum = value;
         }
      }
      public string State
      {
         get
         {
             return state;
         }
         set
         {
            state = value;
         }
      }
      public int MotorSizeInHP
      {
         get
         {
            return motorSizeInHP;
         }
         set
         {
            motorSizeInHP = value;
            if(MotorSizeInHP < HPCUTOFF)
               price = LOWFEE;
            else
               price = HIGHFEE;
         }
      }
      public double Price
      {
         get
         {
            return price;
         }
      }
  
   }