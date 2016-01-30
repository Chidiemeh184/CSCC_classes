// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using System;
public class DebugFive1
{
  public static void Main()
  {
   const string PASS1 = "home";
   const string PASS2 = "lady";
   const string PASS3 = "mouse";
   string password;

   Console.Write("Please enter your password ");
   password = ReadLine();
   while(password != PASS1 || password != PASS2 || password != PASS3)
   {
      Console.WriteLine("Invalid password. Please enter again. ");
      password = Console.ReadLine()
   }
   Console.WriteLine("Valid password");

   }
}
