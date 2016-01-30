using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
public class SerializableDemonstration
{
   public static void Main()
   {
      const int END = 999;
      const string FILENAME = "Data.ser";
      Employee emp = new Employee();
      FileStream outFile = new FileStream(FILENAME,
         FileMode.Create, FileAccess.Write);
      BinaryFormatter bFormatter = new BinaryFormatter();
      Console.Write("Enter employee number or " + END +
         " to quit >> ");
      emp.EmpNum = Convert.ToInt32(Console.ReadLine());
      while(emp.EmpNum != END)
      {
         Console.Write("Enter last name >> ");
         emp.Name = Console.ReadLine();
         Console.Write("Enter salary >> ");
         emp.Salary = Convert.ToDouble(Console.ReadLine());
         bFormatter.Serialize(outFile, emp);
         Console.Write("Enter employee number or " + END +
            " to quit >> ");
         emp.EmpNum = Convert.ToInt32(Console.ReadLine());
      }
      outFile.Close();
      FileStream inFile = new FileStream(FILENAME,
         FileMode.Open, FileAccess.Read);
      Console.WriteLine("\n{0,-5}{1,-12}{2,8}\n",
         "Num", "Name", "Salary");
      while(inFile.Position < inFile.Length)
      {
         emp = (Employee)bFormatter.Deserialize(inFile);
         Console.WriteLine("{0,-5}{1,-12}{2,8}",
            emp.EmpNum, emp.Name, emp.Salary.ToString("C"));
      }
      inFile.Close();
   }
}
[Serializable]
class Employee
{
   public int EmpNum {get; set;}
   public string Name {get; set;}
   public double Salary {get; set;}
}
