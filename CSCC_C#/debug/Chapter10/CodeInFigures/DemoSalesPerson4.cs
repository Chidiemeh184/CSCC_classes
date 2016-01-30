using System;
public class DemoSalesperson4
{
   public static void Main()
   {
      CommissionEmployee salesperson = new CommissionEmployee();
   }
}
class Employee
{
   private int empNum;
   protected double empSal;
   public Employee()
   {
      Console.WriteLine("Employee constructed");
   }
}
class CommissionEmployee : Employee
{
   private double commissionRate;
   public CommissionEmployee()
   {
      Console.WriteLine("CommissionEmployee constructed");
   }
}
