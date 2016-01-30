/*
*   Assignment: Lab 8 - Exercise 3
*   Program:    CarInsurance(main), CalculateInsurance
*   Author:     Chidi Emeh
*   Date:       12/4/2015
*   Description: This program calculates the car insurance for a user
*                based on the given age and state. An Exception is throw
*                where the wrong input is given.
**/

using System;

namespace Lab8Assignment
{
     class CarInsurance 
    {
        private static int age;
        private static string temp, state;
        private static string answer;
        private const string key = "n";


        public CarInsurance()
        {
            State = "";
        }


        public int Age 
        {
            get
            {
                return age;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
               
            }
        
        }

        static void Main(string[] args)
        {

            Console.WriteLine("**Illinois/Wisconsin**");
            Console.WriteLine("  Vehicle Insurance Co.");
            Console.WriteLine();
            Console.Write("Would you like to run this program [y, n]? ");
            answer = Console.ReadLine();
            while(!answer.Equals("n"))
            {
                if(String.Equals(answer, "y", StringComparison.OrdinalIgnoreCase))
                {

    
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Enter the driver's age (rounded value): ");

                        temp = Console.ReadLine();
                        Console.WriteLine("");
                        Console.Write("Enter the state abbreviation (two letters,\nin any combination of upper or lower case characters): ");
                        state = Console.ReadLine();
                        age = Convert.ToInt32(temp);

                        CalculateInsurance insurance = new CalculateInsurance();
                        double amountOfInsurance = insurance.Calculate(age, state);
                        Console.WriteLine("");
                        Console.WriteLine("For the {0} years old driver in the state of {1}", age, state);
                        Console.WriteLine("the insurance premium is: {0:C}", amountOfInsurance);
                        Console.WriteLine("");


                    }
                       
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }

                    catch (System.FormatException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ex.Message + " Enter a Valid age.");
                        Console.WriteLine();
                    }

                    finally
                    {
                        Console.Write("Would you like to run this program [y, n]? ");
                        answer = Console.ReadLine();
                    }
                    
                }

                else
                {
                    Console.Write("Would you like to run this program [y, n]? ");
                    answer = Console.ReadLine();
                }
                
            }
            
            Console.WriteLine();
            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.ReadLine();
        }
    }

     class ArgumentException : Exception
     {
         public static string msg = "The state " +(new CarInsurance().State) + " is not covered by the insurance company. \nThe only covered states are IL and WI.";
         public ArgumentException() : base(msg) { }
     }
}
