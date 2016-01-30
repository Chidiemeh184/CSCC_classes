/*
	Chapter :	Lab 7, Question 1
	Programmer:	Chidi Emeh
	Date:		10/30/2015
	Filename:	ArraySum.java
	Purpose:	This program prompts a user to enter
				some numbers and then finds the sum
				using array method overloads.
*/


import java.util.Scanner;

public class ArraySum
{
	public static void main (String[] args)
	{
		//////////////////////// Declare Variables and Initialize Objects   //////////////////////
		Scanner input = new Scanner(System.in);
		int[] list1 = new int[10];
		double[] list2 = new double[10];
		int answer1;
		double answer2;


		//////////////////////////////////////   Request User Input for first Array     //////////
		System.out.printf("\tAverage arrays");
		System.out.println();
		System.out.println();
		System.out.print("Enter 10 integer values: ");
		for(int i=0; i<list1.length; i++)
		{
			list1[i] = input.nextInt();
		}
		answer1 = average(list1);
		System.out.println(" The average of the ten integers is "+ answer1);


		//////////////////////////////////////   Request User Input for Second Array     ///////////
		System.out.println();
		System.out.print("Enter 10 double values: ");
		for(int i=0; i<list2.length; i++)
		{
			list2[i] = input.nextDouble();
		}
		answer2 = average(list2);
		System.out.println(" The average of the ten doubles is "+ answer2);


	}


	///////////////////      Method to find average of integer array       //////////////////////////
	public static int average(int[] array)
	{
		int sum  = 0;
		int average = 0;
		for(int num: array)
		{
			sum = sum + num;
		}
		average = sum/array.length;
		return average;
	}

	///////////////////      Method to find average of a double array       //////////////////////////
	public static double average(double[] array)
	{
		double sum  = 0;
		double average = 0;
		for(double num: array)
		{
		  sum = sum + num;
		}
		average = sum/array.length;
		return average;
	}
}