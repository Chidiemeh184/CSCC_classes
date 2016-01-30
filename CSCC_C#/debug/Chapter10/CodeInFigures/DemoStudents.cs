using System;
class DemoStudents
{
   public static void Main()
   {
      Student payingStudent = new Student();
      ScholarshipStudent freeStudent = new ScholarshipStudent();
      payingStudent.Name = "Megan";
      payingStudent.Credits = 15;
      freeStudent.Name = "Luke";
      freeStudent.Credits = 15;
      Console.WriteLine("{0}'s tuition is {1}",
         payingStudent.Name,
         payingStudent.Tuition.ToString("C"));
      Console.WriteLine("{0}'s tuition is {1}",
         freeStudent.Name,
         freeStudent.Tuition.ToString("C"));
   }
}
class Student
{
   private const double RATE = 55.75;
   private string name;
   protected int credits;
   protected double tuition;
   public string Name
   {
      get
      {
         return name;
      }
      set
      {
         name = value;
      }
   }

   public virtual int Credits
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
    public override int Credits
    {
      set
      {
         credits = value;
         tuition = 0;
      }
    }
}
