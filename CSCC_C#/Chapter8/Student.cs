using System;


class Student
{
    private int idNumber;
    private string lastName;
    private double gradePointAverage;

    public const double HIGHEST_GPA = 4.0;
    public const double LOWEST_GPA = 0.0;

    public int IdNumber
    {
        get { return idNumber; }
        set { idNumber = value; }

    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public double GradePointAverage
    {
        get { return gradePointAverage; }
        set
        {
            if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                gradePointAverage = value;
            else
                gradePointAverage = LOWEST_GPA;
        }
    }

    public Student(int idNumber, string name, double gpa)
    {
        this.idNumber = idNumber;
        lastName = name;
        gradePointAverage = gpa;
    }

    public Student() : this(0, "XXX", 0.0)
    {

    }
}
