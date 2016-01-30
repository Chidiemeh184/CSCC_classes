using System;
public class TwoErrors2
{
   public static void Main()
   {
      int num = 13, denom = 0, result;
      int[] array = {22, 33, 44};
      try
      {
          result = array[num];
          result = num / denom;
      }
      catch(DivideByZeroException error)
      {
         Console.WriteLine("In first catch block: ");
         Console.WriteLine(error.Message);
      }
      catch(IndexOutOfRangeException error)
      {
         Console.WriteLine("In second catch block: ");
         Console.WriteLine(error.Message);
      }
   }
}
