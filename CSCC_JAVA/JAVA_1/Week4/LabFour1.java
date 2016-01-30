/**
* Assignment: Lab 4, Question 1
* Name: Chidi Emeh
* Date: 09/26/2015
* Program: LabFour1.java
* Description: This program asks for a user input and calculates
*			   the cout, sum and average. An error message is
*			   displayed when the user enters a wrong value.
**/

import java.util.Scanner;

public class LabFour1
{
	public static void main(String[] args)
	{
		/////////////////////   Declare Variables  //////////////////////////////////////
		int num, count = 0, countPositive = 0, countNegative = 0, sum = 0;
		double average;
		String userInput;

		Scanner input = new Scanner(System.in);


		/////////////////////   Request Input   /////////////////////////////////////////
 		System.out.print("Enter an integer - type a 0 to end: ");
		num = input.nextInt();


		////////////////////   Make Loop Decision   //////////////////////////////////////
		while (num != 0)
		{
			if (num < 0)
			{
				countNegative++;
			}
			count++;
			countPositive = count - countNegative;
			sum = sum + num;

			System.out.println();
			System.out.print("Enter an integer - type a 0 to end: ");
			num = input.nextInt();

		}

		////////////////////////// Check if count is greater or user enters a value ////////////
		if (count > 0)
		{
			average =(double) sum / count;
			System.out.println();
			System.out.println("The number of positives is " + countPositive);
			System.out.println("The number of negatives is " + countNegative);
			System.out.println("The total is " + sum);
			System.out.println("The average is " + average);
		}

		/////////////////////////// Diplay message is User enetered no value  /////////////////////
		else
		{
			System.out.println();
			System.out.println("no numbers are entered except 0");
		}
	}
}