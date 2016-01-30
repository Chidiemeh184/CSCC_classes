using System;

class ClassDemo1
{
    static void Main()
    {
        try
        {
            AnotherMethod();
        }

        catch(Exception ex)
        {
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Message);
            Console.Read();
        }

    }

    static void AnotherMethod()
    {
        int result, zero = 0;
        //result = 3 / zero;

        if (zero == 0)
            throw new OurException();
    }
}

class OurException : Exception
{
    public static string msg = "OurException was thrown";
    public OurException() : base(msg)
    { 

}
}