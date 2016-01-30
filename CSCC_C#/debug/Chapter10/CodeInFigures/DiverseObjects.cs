using System;
class DiverseObjects
{
   public static void Main()
   {
      Student payingStudent = new Student();
      ScholarshipStudent freeStudent = new ScholarshipStudent();
      Employee clerk = new Employee();
      Console.Write("Using Student: ");
      DisplayObjectMessage(payingStudent);
      Console.Write("Using ScholarshipStudent: ");
      DisplayObjectMessage(freeStudent);
      Console.Write("Using Employee: ");
      DisplayObjectMessage(clerk);
   }
   internal static void DisplayObjectMessage(Object o)
   {
      Console.WriteLine("Method successfully called");
   }
}

class Employee
{
   private int empNum;
   private double empSal;
   public int EmpNum
   {
      get
      {
         return empNum;
      }
      set
      {
         empNum = value;
      }
   }
   public double EmpSal
   {
      get
      {
         return empSal;
      }
      set
      {
         empSal = value;
      }
   }

   public string GetGreeting()
   {
      string greeting = "Hello. I am employee #" + EmpNum;
      return greeting;
   }
}

class Student
{
   private const double RATE = 55.75;
   protected int credits;
   protected double tuition;
   public string Name {get; set;}

   public int Credits
   {
      get
      {
         return credits;
      }
      set
      {
          credits = value;
          tuition = credits * RATE;
      }
   }
   public double Tuition
   {
      get
      {
         return tuition;
      }
   }
}

class ScholarshipStudent : Student
{
    new public int Credits
    {
      set
      {
         credits = value;
         tuition = 0;
      }
    }
}
