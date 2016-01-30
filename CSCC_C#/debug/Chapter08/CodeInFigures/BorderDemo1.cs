using System;
public class BorderDemo1
{
   public static void Main()
   {
      DisplayWithBorder("Ed");
      DisplayWithBorder("Theodore");
      DisplayWithBorder("Jennifer Ann");
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
}
