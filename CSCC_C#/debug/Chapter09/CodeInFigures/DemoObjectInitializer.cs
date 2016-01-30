using System;
public class DemoObjectInitializer
{
   public static void Main()
   {
      Employee aWorker = new Employee {IdNumber = 101};
      Console.WriteLine("Employee #{0} exists. Salary is {1}.",
         aWorker.IdNumber, aWorker.Salary);
   }
}
class Employee
{
   public int IdNumber {get; set;}
   public double Salary {get; set;}
   public Employee()
   {
      Salary = 99.99;
      Console.WriteLine("Employee #{0} created. Salary is {1}.",
         IdNumber, Salary);
   }
}
