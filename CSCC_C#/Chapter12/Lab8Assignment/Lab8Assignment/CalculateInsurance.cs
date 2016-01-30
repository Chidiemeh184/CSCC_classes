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
    class CalculateInsurance
    {

        public double Calculate(int age, string state)
        {
            double newpay, pay;

            pay = (100 - age) * 3;

            if(String.Equals(state, "WI" , StringComparison.OrdinalIgnoreCase))
            {
                newpay = pay + 50;
            }

            else if(String.Equals(state, "IL" , StringComparison.OrdinalIgnoreCase))
            {
                newpay = pay + 100;
            }

            else
            {
                throw new ArgumentException();
            }

            return newpay;
        }
    }
}
