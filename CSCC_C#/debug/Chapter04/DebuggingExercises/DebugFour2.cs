// Program asks user to enter three integers
// Program displays a message indicating whether the numbers
// are in sequential order
// in reverse order
// or in neither order
using System;
public class DebugFour2
{
   int num1, num2, num3;
   string snum1, snum2, snum3;
   Console.Write("Enter first number ");
   num1 = Console.ReadLine();
   snum1 = Convert.ToInt32(num1);
   Console.Write("Enter second number ");
   snum2 = ConsoleReadLine();
   num2 = Convert.ToInt32(snum2);
   Console.Write("Enter third number ");
   snum3 = Console.WreadLine();
   num3 = Convert.ToInt32(snum3);
   if(num1 <= num2 || num2 <= num3)
      Console.WriteLine("Numbers are in sequential order");
   else
      if(num1 >= num2)
         Console.WriteLine("Numbers are in reverse order");
      else
         Console.WriteLine("Numbers are in neither sequential nor reverse order");
}
