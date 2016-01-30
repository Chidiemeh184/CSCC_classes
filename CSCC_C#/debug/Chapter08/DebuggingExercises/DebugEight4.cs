// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'
using System;
public class DebugEight4
{
   public static void Main()
   {
       FancyDisplay(33);
       FancyDisplay(44, '@');
       FancyDisplay(55.55);
       FancyDisplay(77.77, '*');
       FancyDisplay("hello");
       FancyDisplay("goodbye", "#");
   }
   public static void FancyDisplay(char decoration = 'X', in num)
   {
      Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
         decoration, num); 
   }
   public static FancyDisplay(double num, decoration = 'X')
   {
      Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
         decoration, num.ToString("C")); 
   }
   public static void FancyDisplay(sting word, char decoration = 'X')
   {
      Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n",
         decoration, word) 
   }

}
