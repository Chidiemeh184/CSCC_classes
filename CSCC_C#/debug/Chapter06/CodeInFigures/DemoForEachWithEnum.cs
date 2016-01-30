using System;
public class DemoForEachWithEnum
{
   enum Day
   {
      SUNDAY, MONDAY, TUESDAY, WEDNESDAY,
        THURSDAY, FRIDAY, SATURDAY
   }
   public static void Main()
   {
      foreach(string day in Enum.GetNames(typeof(Day)))
        Console.WriteLine(day);
   }
}


