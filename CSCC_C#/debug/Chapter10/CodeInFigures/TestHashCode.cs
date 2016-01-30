using System;
public class TestHashCode
{
   public static void Main()
   {
      Employee first = new Employee();
      Employee second = new Employee();
      Console.WriteLine(first.GetHashCode());
      Console.WriteLine(second.GetHashCode());
   }
}
class Employee
{
   private int empNum;
   private double empSal;
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
         empSal = value;
      }
   }

   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + EmpNum;
      return greeting;
   }
}
