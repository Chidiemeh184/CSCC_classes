using System;
using System.IO;
public class DirectoryInformation
{
   public static void Main()
   {
      string directoryName;
      string[] listOfFiles;
      Console.Write("Enter a folder >> ");
      directoryName = Console.ReadLine();
      if(Directory.Exists(directoryName))
      {
         Console.WriteLine("Directory exists, " +
            "and it contains the following:");
         listOfFiles = Directory.GetFiles(directoryName);
         for(int x = 0; x < listOfFiles.Length; ++x)
           Console.WriteLine("   {0}", listOfFiles[x]);
      }
      else
      {
         Console.WriteLine("Directory does not exist");
      }
   }
}
