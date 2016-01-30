using System;

class Program
{
     static void Main()
    {
        try
        {
            int answer, result, zero = 0; //zero = 3; 
            Console.Write("Enter an integer >> ");
            answer = Convert.ToInt32(Console.ReadLine());
            result = answer / zero;
            Console.WriteLine("The answer is " + result);
        }

       // catch(System.DivideByZeroException ex)
        //{
            //Console.WriteLine("Divide by zero error");
            //Console.ReadLine();
        //}

        //catch(System.FormatException ex)
        //{
           // Console.WriteLine("A Format exception error occured");
            //Console.ReadLine();
        //}

        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            //Console.WriteLine("A Format exception error occured");
           // Console.ReadLine();
        }

        finally
        {
            Console.WriteLine("Inside finally block. Cleaning up. ");
            Console.ReadLine();
        }
        
    }
}
