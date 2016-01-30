using System;
public class DivisionBasedOnMajor
{
   enum Major
   {
      ACCOUNTING = 1, CIS, ENGLISH, MATH, MARKETING
   }
   public static void Main()
   {
      int major;
      Console.Write("Enter major code >> ");
      major = Convert.ToInt32(Console.ReadLine());
      switch ((Major) major)
      {
         case Major.ACCOUNTING:
         case Major.CIS:
         case Major.MARKETING:
            Console.WriteLine("Major is in the Business Division");
            break;
         case Major.ENGLISH:
         case Major.MATH:
            Console.WriteLine("Major is in the Humanities Division");
            break;
         default:
            Console.WriteLine("Major code is invalid");
            break;
      }
   }
}
