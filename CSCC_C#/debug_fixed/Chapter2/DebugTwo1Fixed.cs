// Program compares your name to the name of your boss
using System;
public class DebugTwo1Fixed
{
    public static void Main()
    {
        string name, bossName;

        Boolean areNamesTheSame;
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        Console.WriteLine("Hello {0}! Enter the name of your boss", name);
        bossName = Console.ReadLine();
        areNamesTheSame = String.Equals(name, bossName);
        Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);

        Console.Read();
    }
}
