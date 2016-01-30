using System;
public class BorderDemo2
{
   public static void Main()
   {
      DisplayWithBorder("Ed");
      DisplayWithBorder(3);
      DisplayWithBorder(456);
      DisplayWithBorder(897654);
      DisplayWithBorder("Veronica");
   }
   public static void DisplayWithBorder(string word)
   {
      const int EXTRA_STARS = 4;
      const string SYMBOL = "*";
      int size = word.Length + EXTRA_STARS;
      int x;
      for(x = 0; x < size; ++x)
         Console.Write(SYMBOL);
      Console.WriteLine();
      Console.WriteLine(SYMBOL + " " + word + " " + SYMBOL);
      for(x = 0; x < size; ++x)
         Console.Write(SYMBOL);
      Console.WriteLine("\n\n");
   }
   public static void DisplayWithBorder(int number)
   {
      const int EXTRA_STARS = 4;
      const string SYMBOL = "*";
      int size  = EXTRA_STARS + 1;
      int leftOver = number;
      int x;
      while(leftOver >= 10)
      {
         leftOver = leftOver / 10;
         ++size;
      }
      for(x = 0; x < size; ++x)
         Console.Write(SYMBOL);
      Console.WriteLine();
      Console.WriteLine(SYMBOL + " " + number + " " + SYMBOL);
      for(x = 0; x < size; ++x)
         Console.Write(SYMBOL);
      Console.WriteLine("\n\n");
   }
}
