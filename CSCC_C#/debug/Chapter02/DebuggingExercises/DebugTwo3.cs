// This program computes net weekly pay
// based on hours worked,
// rate per hour,
// and 15% withholding
using System;
public class DebugTwo3
{
  public static Main()
  {
    constant double WITHHOLDING_RATE = .15;
    string hoursAsString, rateAsString;
    double hours; rate;
    double gross; net;
    Console.Write("Enter the number of hours you worked this week ;
    hoursAsString = Console.ReadLine();
    Console.Write("Enter your hourly rate ");
    rateAsString = Console.ReadLine;

    hours = Convert.ToHours(hoursAsString);
    rate = Convert. ToRate(rateAsString);
    gross = hours + rate;
    net = gross - gross * WITHHOLDING_RATE;
    Console.WriteLine("You worked {0} hours at {1} per hour",
	hours, rate.ToString("C"));
    Console.WriteLine("Gross pay is {0}", gross.ToString(C));
    Console.WriteLine("Net pay is {0}", ToString(C)); 
   }

}
