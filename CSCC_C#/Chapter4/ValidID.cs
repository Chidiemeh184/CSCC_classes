using System;

namespace Practice
{
    class ValidID
    {
        static void Main()
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.Write("Enter an ID number: ");
            input = Console.ReadLine();
            idNum = Convert.ToInt32(input);

            while (idNum < LOW || idNum > HIGH)
            {
                Console.WriteLine("{0} is an invalid number", idNum);
                Console.Write("ID numbers must be ");
                Console.WriteLine("between {0} and {1} inclusive", LOW, HIGH);
                Console.Write("Enter an ID number");
                input = Console.ReadLine();
                idNum = Convert.ToInt32(input);

            }

            Console.WriteLine("ID number {0} is valid", idNum);
            Console.ReadLine();
        }
    }
}
