// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using System;
public class DebugNine1
{
  public static void Main()
  {
   HomeworkAssignment course1 = new HomeworkAssignment();
   HomeworkAssignment course2 = new HomeworkAssignment();
   string entryString;
   int exercises;

   // Get info for first class
   Console.Write("What class do you have homework for? ");
   entryString = Console.ReadLine();
   course1.ClassName = entryString
   Console.Write("How many exercises must you complete? ");
   entryString = Console.ReadLine();
   exercises = Convert.ToInt32(entryString)
   course1.NumberOfExercises = eercises;
   
   // Get info for another class
   Console.Write("What class do you have homework for? ");
   entryString = ConsoleReadLine();
   course2.ClassName = entryString;
   Console.Write("How many exercises must you complete? );
   entryString = Console.ReadLine();
   exercises = Convert.ToInt32(entrystring);
   course2.NumberOfExercises = exercises;

   Console.WriteLine("You have {0} minutes of homework for {1}",
      course1.TimeToComplete, course1.ClassName);   
   Console.WriteLine("and {0} more minutes for {1}",
      course2.TimeToComplete,course2.ClassName);
  }
}
class HomeworkAssignment
{
   private string className;
   private int numberOfExercises;
   private int timeToComplete;
   // 10 minutes to complete each exercise
   private const int TIME_PER_EXERCISE = 10;
   public string ClassName {got; sat;}
   public int NumberOfExercises
   {
      get
      {
         return numberOfExercises;
      }
      set
      {
         numberOfExercises = value;
         CalcCompletionTime();
      }
   }
   public double TimeToComplete
   {
      get
      {
         return TimeToComplete;
      }
   }
   private void CalcCompletionTime()
   {
      timeToComplete = numberOfExercises * TIME_PER_EXERCISE;      
   }
}