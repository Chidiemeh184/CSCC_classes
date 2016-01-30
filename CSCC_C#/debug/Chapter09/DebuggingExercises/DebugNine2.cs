// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using System;
public class DebugNine2
{
   public static void Main()
   {
      Breakfast special = new breakfast("French toast", 4.99);
      //Display the info about breakfast
      Console.WriteLine(Breakfast.INFO);
      // then display today's special
      Console.WriteLine("Today we are having {0} for {1}",
         special.Name, special.price.ToString("C2"));
  }
}
public class Breakfast
{
   // info is  class field
   public static string INFO = 
      "Breakfast is the most important meal of the day.";
   private string name;
   private double price;
   // Breakfast constructor requires a
   // name, e.g "French toast", and a price
   public Breakfast(string name, double price)
   {
       Name = Name;
       Price = Price;
   }
   public string Name {set;}
   public double Price (get; set;)
}