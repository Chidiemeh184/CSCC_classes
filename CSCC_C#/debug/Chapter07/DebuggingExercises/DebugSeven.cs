// This program uses the Array.BinarySearch method
// to find a target within an array.
// Fix both the logic and syntax errors.

using System;

class DebugSeven
{
    static avoid Main(string[] args)
    {
        // WARNING: The array firstNames cannot be changed
        //  in any way.
        // ------------------------------------------------
        string[] firstNames = { "Johnny", "Alice", "Cory",
                                "Steve", "Dennis" };
        // ------------------------------------------------

        int index;
        string searchedName = PromptName();
        while (searchedName.Equals("end"))
        {
            index = Array.BinarySearch(firstNames, searchedName);
            Display(index, searchedName);
        }

        Console.Read();
    }

    private void Display(int index, string name)
    {
        Console.WriteLine();
        if (index >= 0)
        {
            Console.WriteLine("Yes, {0} is in our course.", searchedName);
        }
        else
        {
            Console.WriteLine("No, {0} is not in our course.", name);
        }
        Console.Write();
    }

    private string PromptName()
    {
        Console.Write("To terminate the program, enter 'end' for the student name.");
        Console.Write("Enter the first name of the student to be searched in our course: ");
        return Console.ReadLine();
    }
}

