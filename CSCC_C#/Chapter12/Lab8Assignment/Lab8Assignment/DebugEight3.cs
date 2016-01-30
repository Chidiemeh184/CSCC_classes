// Program demonstrates method that can be called
// with one, two, or three arguments
// Tuition is $80 per credit
// Default district code is I.
// If student is in-district (code I), then there is no
// out-of-disctrict fee, which is $300
// Default scholarhip status is false.
// If student is on scholarship, tuition is free
using System;
public class DebugEight3
{
   public static void Main()
   {
      Console.WriteLine("Tuition is {0}", CalculateTuition(15));
      Console.WriteLine("Tuition is {0}", CalculateTuition(15, 'O'));
      Console.WriteLine("Tuition is {0}", CalculateTuition(15, 'O', true));
   }
   public static double CalculateTuition(char code = 'I', double credits, bool scholarship = false)
   {
      double tuition;
      const double RATE = 80.00;
      const double OUT_DISTRICT_FEE = 300.00;
      tuition = credits * RATE;
      if(code == 'I')
         tuition += OUT_DISTRICT_FEE;
      if(scholarship)
         tuition = 0;
      return tuition;
   }
}
