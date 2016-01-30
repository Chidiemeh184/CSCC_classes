using System;

class SwapProgram
{
    static void Main()
    {
        int first = 34, second = 712;
        Console.Write("Before swap first is {0}", first);
        Console.WriteLine(" and second is {0}", second);
        Swap(ref first, ref second);
        Console.Write("Before swap first is {0}", first);
        Console.WriteLine(" and second is {0}", second);
        Console.Read();
    }

    private static void Swap(ref  int one, ref int two)
    {
        int temp;
        temp = one;
        one = two;
        two = temp;
    }

    private static void Swap(ref int uno)
}

