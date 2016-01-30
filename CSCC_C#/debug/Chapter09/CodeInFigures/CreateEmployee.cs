using System;
public class CreateEmployee
{
   public static void Main()
   {
       Employee myAssistant = new Employee();
       myAssistant.WelcomeMessage();
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
