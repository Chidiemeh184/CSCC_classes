using System;

class CreateStudents
{
    static void Main()
    {
        Student first = new Student();
        Student second = new Student();
        Student third = new Student(456, "Marco", 2.4);
        Student fourth = new Student();

        first.GradePointAverage = 3.5;
        first.IdNumber = 123;
        first.LastName = "Anderson";

        second.GradePointAverage = 4.1;
        second.IdNumber = 789;
        second.LastName = "Daniels";

        Display(first);
        Display(second);
        Display(third);
        Display(fourth);
        Console.Read();

    }

    static void Display(Student stu)
    {
        Console.WriteLine("{0, 5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage);
    }
}
