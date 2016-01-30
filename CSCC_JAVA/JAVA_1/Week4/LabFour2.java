/**
* Assignment: Lab 4, Question 2
* Name: Chidi Emeh
* Date: 09/26/2015
* Program: LabFour2.java
* Description: This program asks for a user input and calculates
*			   the cout, sum and average. An error message is
*			   displayed when the user enters a wrong value.
**/

import java.util.Scanner;

public class LabFour2
{
	public static void main(String[] args)
	{
		/////////////////////   Declare Variables  /////////////////////////////////
		int num, count= 0 , max= 0;
		String userInput;

		Scanner input = new Scanner(System.in);


		////////////////////   	Display Header    //////////////////////////////////
		System.out.println("         Find the maximum number");
		System.out.println();


		/////////////////////   Get User Input   ////////////////////////////////////
		System.out.print("Enter an integer <0 ends the input>: ");
		num = input.nextInt();



		///////////////////////   Loop Decision   //////////////////////////////////
		while(num != 0)
		{
			if (num > max)
			{
			   max = num;                               //set number to max
			   count = 1;
			}

 		    //Get second/subsequent  Input
     		System.out.print("Enter an integer <0 ends the input>: ");
			num = input.nextInt();

			if (num > max)                             //Check if number is greater
			{										   //than max.
				max = 0;							   //Reset max
				count = 0;							   //Reset count
			}

			if (num == max)                        		//Check is number and max are
			{											//equal.
				count++;
			}

		}

		/////////////////////////   Display Result   //////////////////////////////
		if (count > 0)
		{

			System.out.println("The maximum number is: "+ max);
			System.out.println("The count for the max number is "+ count);
		}
		else
		{
			System.out.println("No numbers are entered except 0");
		}
	}
}

