using System;
class CreateEmployee3
{
   public static void Main()
   {
      Employee aWorker = new Employee();
      aWorker.IdNumber = 3872;
      aWorker.Salary = 22.11;
      Console.WriteLine("Employee #{0} makes {1}",
         aWorker.IdNumber, aWorker.Salary.ToString("C"));
   }
}
class Employee
{
   public int IdNumber {get; set;}
   public double Salary {get; set;}
}
