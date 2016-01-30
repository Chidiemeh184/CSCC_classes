/*
	Chapter :	Lab 7, Question 2
	Programmer:	Chidi Emeh
	Date:		10/30/2015
	Filename:	MinimumArray.java
	Purpose:	This program prompts a user for values
				and find the minimum value in a stored array
*/

import java.util.Scanner;

public class MinimumArray
{
	public static void main (String[] args)
	{
		/////// Declare Variables Initialize objects   ///////
		Scanner input = new Scanner(System.in);
		double[] list1 = new double[10];
		double answer;


		//////// Request User Input   /////////
		System.out.printf("\tFind the minimum value");
		System.out.println();
		System.out.println();
		System.out.print("Enter ten double numbers: ");
		for(int i=0; i<list1.length; i++)
		{
			list1[i] = input.nextDouble();
		}
		answer = minimumInArray(list1);

		///////////////  Display Result   ///////////
		System.out.println("The smallest element is "+answer);

	}


	//////////// Method to find Minimum Nummber in an Array  ///////
	public static double minimumInArray(double[] array)
	{

		double smallestNumberSoFar = array[0];
         for(int i=0; i<array.length; i++)
         {
 			if (array[i] < smallestNumberSoFar)
 			{
				smallestNumberSoFar = array[i];
			}
		 }
         return smallestNumberSoFar;
	}
}