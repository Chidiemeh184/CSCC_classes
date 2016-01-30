using System;
public class CreateTwoEmployees
{
   public static void Main()
   {
      Employee aWorker = new Employee();
      Employee anotherWorker = new Employee();
      DisplayEmployeeData("First", aWorker);
      DisplayEmployeeData("Second", anotherWorker);
   }
   internal static void DisplayEmployeeData(string order, Employee emp)
   {
      Console.WriteLine("\n{0} employee's message:", order);
      emp.WelcomeMessage();
   }
}

class Employee
{
   private int idNumber;
   public void WelcomeMessage()
   {
       Console.WriteLine("Welcome from Employee #{0}", idNumber);
       Console.WriteLine("How can I help you?");
   }
}
