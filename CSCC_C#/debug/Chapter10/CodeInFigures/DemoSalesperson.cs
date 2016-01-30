using System;
public class DemoSalesperson
{
   public static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
      salesperson.EmpNum = 345;
      salesperson.EmpSal = 20000;
      salesperson.CommissionRate = 0.07;
      Console.WriteLine("Salesperson #{0} makes {1} per year",
         salesperson.EmpNum,
         salesperson.EmpSal.ToString("C"));
      Console.WriteLine("...plus {0} commission on all sales",
         salesperson.CommissionRate.ToString("P"));
   }
}
class Employee
{
   private int empNum;
   protected double empSal;
   public int EmpNum
   {
      get
      {
         return empNum;
      }
      set
      {
         empNum = value;
      }
   }

   public double EmpSal
   {
      get
      {
         return empSal;
      }
      set
      {
         double MINIMUM = 15000;
         if(value < MINIMUM)
            empSal = MINIMUM;
         else
            empSal = value;
      }
   }
   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + EmpNum;
      return greeting;
   }
}
class CommissionEmployee : Employee
{
   private double commissionRate;
   public double CommissionRate
   {
      get
      {
         return commissionRate;
      }
      set
      {
         commissionRate = value;
         empSal = 0;
      }
   }
}
