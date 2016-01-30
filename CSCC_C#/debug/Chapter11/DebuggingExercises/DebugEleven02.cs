// Prevents non-numeric data entry
// Then prevents division by 0
using System;
public class DebugEleven02
{
   public static void Main()
   {
      int num = 0, denom = 0, result;
      bool dataEntryIsValid = false;
      while(!dataEntryIsValid)
      {
         try
            DataEntry(out num, out denom);
            dataEntryIsValid = true;
         catch(FormatException e)
            Console.WriteLine("Invalid entry - please enter numbers");
      }
      try 
      {
         result = num / denom;
         Console.WriteLine("Division is successful");
      }
      catch(DivideByZeroException e)
      {
         Console.WriteLine("Division failed");
         result = 0;
      }
      Console.WriteLine("Result is ", result);
   }
   public static void DataEntry(out int num, out int denom)
   {
      string strNum;
      Console.Write("Enter a number ");
      strNum = Console.ReadLine();
      num = Convert.ToInt(strNum);
      Console.Write("Enter a number to divide into the first ");
      strNum = Console.ReadLine();
      denom = Convert.ToInt(strNum);
   }
}
