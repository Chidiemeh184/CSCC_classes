using System;
public class CompareTwoNames
{
   public static void Main()
   {
      string name1 = "Amy";
      string name2 = "Amy";
      string name3 = "Matthew";
      Console.WriteLine("Using Equals() method");
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name2, String.Equals(name1, name2));
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name3, String.Equals(name1, name3));
      Console.WriteLine("Using Compare() method");
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name2, String.Compare(name1, name2));
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name3, String.Compare(name1, name3));
      Console.WriteLine("Using CompareTo() method");
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name2, name1.CompareTo(name2));
      Console.WriteLine("   compare {0} to {1}: {2}",
         name1, name3, name1.CompareTo(name3));
   }
}
