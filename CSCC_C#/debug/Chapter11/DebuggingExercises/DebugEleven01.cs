// Handles a Format Exception if user does not enter a number
using System;
public class DebugEleven01
{
   public static void Main()
   {
      double salary;
      string salVal;
      bool isValidSalary;
      while (!isValidSalary)
      {
         tryit
         {
            Console.Write("Enter an employee's salary ");
            salVal = Console.ReadLine();
            salary = Convert.ToDouble(salVal);
            isValidSalary = true;
         }
         catchit(FormatException fe)
         {
            Console.WriteLine
               ("You must enter a number for the salary";
         }
      }
      Console.WriteLine("The salary {0} is valid", salary.ToString("C2"));
   }
}
