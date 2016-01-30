using System;

class OutsideMainMethods
{
    static void Main()
    {
        Console.Write("Our company is");
        DisplayCompanyLogo();
        Console.Read();
    }

    private static void DisplayCompanyLogo()
    {
        Console.WriteLine(" See the Sharp Optical");
        Console.WriteLine("We prize your eyes");
    }
}
