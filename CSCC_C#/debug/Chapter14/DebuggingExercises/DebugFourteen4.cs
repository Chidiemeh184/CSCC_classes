// Reads and write serializable Student objects
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
public class DebugFourteen4
{
   public static void Main()
   {
      const int END = 999;
      const string FILENAME = "Students.ser";
      Student stu = new Student();
      FileStream outFile = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
      BinaryFormatter bFormatter = new BinaryFormatter();
      Console.Write("Enter Student number or " + END + " to quit ");
      stu.StuNum = Convert.ToInt32(Console.ReadLine());
      while(stu.StuNum != END)
      {
         Console.Write("Enter last name ");
         Name = Console.ReadLine();
         Console.Write("Enter gpa ");
         Gpa = Convert.ToDouble(Console.ReadLine());
         bFormatterSerialize(outFile, stu);
         Console.Write("Enter Student number or " + END + " to quit ");
         stu.StuNum = Convert.ToInt32(Console.ReadLine());
      }
      outFile.Close;
      FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
      Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n", "Num", "Name", "GPA"); 
      while(inFile.Position < inFile.Length)
      {
         stu = (Student)bFormatter.Deserialize(inFile);
         Console.WriteLine("{0,-5}{1,-12}{2,8}", stu.StuNum, stu.Name, stu.Gpa.ToString("F2"));
      }
      inFile.Close();
   }
   
}
[Serializble]   
public class Student
{
   private int stuNum;
   private string name;
   private double gpa;
   private const double MINGPA = 0.0;
   private const double MAXGPA = 4.0;
   public int StuNum
   {
      get{return stuNum;}
      set{stuNum = value;}
   }
   public string Name
   {
      get{return name;}
      set{name = value;}
   }
   public double Gpa
   {
      get{return Gpa;}
      set
      {
         if(value >= MINGPA && value <= MAXGPA)
            gpa = value;
         else
            gpa = 0;
      }
   }
}