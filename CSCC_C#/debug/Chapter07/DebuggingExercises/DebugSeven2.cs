// Address an envelope one of two ways
// Using zip code, or using city and state
using System;
public class DebugSeven2
{

  public static void Main()
  {
    string addressee = "Ms. Brooke Jefferson";
    int zipCode = 60007;
    string cityAndState = "Elk Grove, IL";
    AddressMethod(zipCode, addressee);
    Console.WriteLine("-----------------------");
    AddressMethod(addressee, cityAndState);
    Console.WriteLine("-----------------------");
  }
  public static void AddresMethod(string person, int num)
  {
        Console.WriteLine("To : {0}", person);
	Console.WriteLine("Zip: {0}, num);
  }
  public static void AddressMethod(string person, city)
  {
	Console.WriteLine("To : {0}", person);
	Console.WriteLine("{0}", city);
  }
}

