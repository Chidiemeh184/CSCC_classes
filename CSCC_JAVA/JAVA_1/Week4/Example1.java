/**
* Name: Chidi Emeh
* Date: 09/26/2015
* Program: Example1.java
* Description: This program asks for a user input and calculates
*			   the cout, sum and average. An error message is
*			   displayed when the user entered a wrong value.
**/

import java.util.Scanner;

public class Example1
{
	public static void main(String[] args)
	{
		/////////////////////   Declare Variables  //////////////////////////////////////
		int num, count = 0, sum = 0;
		double average;
		String userInput;

		Scanner input = new Scanner(System.in);


		/////////////////////   Request Input   /////////////////////////////////////////
 		System.out.print("Enter a positive integer - type a 0 to end: ");
		num = input.nextInt();


		////////////////////    Make Loop Decision    //////////////////////////////////////
		while (num != 0)
		{
			if (num < 0)
			{
				System.out.println();
				System.out.print("Error - Enter a positive integer - type a 0 to end: ");
				num = input.nextInt();
				continue;
			}
			count++;
			sum = sum + num;

			System.out.println();
			System.out.print("Enter a positive integer - type a 0 to end: ");
			num = input.nextInt();

		}

		////////////////////////// Check if count is greater or user entered a value ////////////
		if (count > 0)
		{
			average = sum / count;
			System.out.println();
			System.out.println("The total number of legal input: " + sum);
			System.out.println("The average of the input is: " + average);
			System.out.println();
		}

		/////////////////////////// Diplay message is User enetred no value  /////////////////////
		else
		{
			System.out.println("No legal values were entered");
			System.out.println();
		}
	}
}