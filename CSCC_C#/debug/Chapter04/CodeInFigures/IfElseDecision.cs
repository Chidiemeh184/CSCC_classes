using System;
public class IfElseDecision
{
   public static void Main()
   {
      const int HIGH = 10;
      string numberString;
      int number;
      Console.Write("Enter an integer ");
      numberString = Console.ReadLine();
      number = Convert.ToInt32(numberString);
      if(number > HIGH)
         Console.WriteLine("{0} is greater than {1}",
            number, HIGH);
      else
         Console.WriteLine("{0} is not greater than {1}",
            number, HIGH);
   }
}
