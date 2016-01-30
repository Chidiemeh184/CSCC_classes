using System;
public class CompareNames1
{
   public static void Main()
   {
      string name1 = "Amy";
      string name2 = "Amy";
      string name3 = "Matthew";
      Console.WriteLine("compare {0} to {1}: {2}",
         name1, name2, name1 == name2);
      Console.WriteLine("compare {0} to {1}: {2}",
         name1, name3, name1 == name3);
   }
}
