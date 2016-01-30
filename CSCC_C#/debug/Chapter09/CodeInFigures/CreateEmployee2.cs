using System;
public class CreateEmployee2
{
   public static void Main()
   {
       Employee myChef = new Employee();
       myChef.IdNumber = 2345;
       Console.WriteLine("ID number is {0}",
          myChef.IdNumber);
       myChef.WelcomeMessage();
   }
}
class Employee
{
   private int idNumber;
   public int IdNumber
   {
      get
      {
         return idNumber;
      }
      set
      {
         idNumber = value;
      }
   }
   public void WelcomeMessage()
   {
       Console.WriteLine("Welcome from Employee #{0}", IdNumber);
       Console.WriteLine("How can I help you?");
   }
}
