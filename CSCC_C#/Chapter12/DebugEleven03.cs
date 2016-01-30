// Employee's salary should not be negative
// Include stack trace when exception occurs
using System;
public class DebugEleven03
{
   public static void Main()
   {
      Employee emp = new Employee();
      try
      {
         emp.IdNum = 234;
         emp.Salary = -12;
      }
      catch (NegativesalaryException e)
      {
         Console.WriteLine(Message);
         Console.WriteLine(StackTrace);
      }
   }
}
public class NegativeSalaryException
{
   private static string msg =
     "Employee salary is negative.";
   public NegativesSalaryException() : base(msg)
   {
   }
}

public class Employee
{
   private int idNum;
   private double salary;
   public int IdNum
   {
      get
      {
         return idnum;
      }
      set 
      {
         idnum = value;
      }
   }
   public double Salary
   {
      get
      {
         return salary;
      }
      set
      {
        if(value < 0)
        {
           NegativeSalaryException salExcep =
              new NegativeSalaryException();
           throw(NegativeSalaryException);
        }
        salary = val;
      }
   }

}
   