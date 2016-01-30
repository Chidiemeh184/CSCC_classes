using System;
public class AmbiguousMethods
{
   public static void Main()
   {
      int iNum = 20;
      double dNum = 4.5;
      SimpleMethod(iNum, dNum);  // calls first version
      SimpleMethod(dNum, iNum);  // calls second version
      SimpleMethod(iNum, iNum);  // error! Call is ambiguous.
   }
   public static void SimpleMethod(int i, double d)
   {
       Console.WriteLine("Method receives int and double");
   }
   public static void SimpleMethod(double d, int i)
   {
       Console.WriteLine("Method receives double and int");
   }
}
