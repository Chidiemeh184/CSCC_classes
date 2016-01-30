using System;
using System.IO;
public class FileStatistics
{
   public static void Main()
   {
      string fileName;
      Console.Write("Enter a filename >> ");
      fileName = Console.ReadLine();
      if(File.Exists(fileName))
      {
         Console.WriteLine("File exists");
         Console.WriteLine("File was created " +
            File.GetCreationTime(fileName));
         Console.WriteLine("File was last accessed " +
            File.GetLastAccessTime(fileName));
         Console.WriteLine("File was last written to " +
            File.GetLastWriteTime(fileName));
      }
      else
      {
         Console.WriteLine("File does not exist");
      }
   }
}
