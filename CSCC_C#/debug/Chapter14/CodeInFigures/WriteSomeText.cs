using System;
using System.IO;
public class WriteSomeText
{
   public static void Main()
   {
      FileStream outFile = new
         FileStream("SomeText.txt", FileMode.Create,
            FileAccess.Write);
      StreamWriter writer = new StreamWriter(outFile);
      Console.Write("Enter some text >> ");
      string text = Console.ReadLine();
      writer.WriteLine(text);
      // Error occurs if the next two statements are reversed
      writer.Close();
      outFile.Close();
   }
}
