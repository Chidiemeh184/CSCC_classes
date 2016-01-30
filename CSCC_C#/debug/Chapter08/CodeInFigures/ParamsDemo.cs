using System;
public class ParamsDemo
{
   public static void Main()
   {
      string[] names = {"Mark", "Paulette", "Carol", "James"};
      DisplayStrings("Ginger");
      DisplayStrings("George", "Maria", "Thomas");
      DisplayStrings(names);
   }
   public static void DisplayStrings(params string[] people)
   {
      foreach(string person in people)
         Console.Write("{0} ", person);
      Console.WriteLine("\n----------------");
   }
}
