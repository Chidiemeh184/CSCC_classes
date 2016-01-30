/*
* Name: Chidi Emeh
* Date: 10/03/2015
* Pragram: MidTerm1.java
* Description: this program asks a user for a name and score
*			   and finds the largest number.
**/

import java.util.Scanner;

public class MidTerm1
{
	public static void main(String[] args)
	{
		///////////////////////    Declare variables   ////////////////////
		int numOfStudents;
		double score1 = 0, score;
		String student1="", student;

		Scanner input = new Scanner(System.in);


		///////////////////////    Display Header    ///////////////////////////////
		System.out.println("        Mid term 1 Lab");
		System.out.println();


		///////////////////////   Request Max number of input //////////////////////
		System.out.print("Enter the number of students: ");
		numOfStudents = input.nextInt();
		System.out.println();


		///////////////////////    Request Name and Score for Max Input  ///////////
		for(int i= 0; i < numOfStudents; i++)
		{
			System.out.print("Enter a student name: ");
			student = input.next();
			System.out.print("Enter a student score: ");
			score = input.nextDouble();

			//Decide Highest score
			if(score > score1){
				score1 = score;
				student1 = student;
			}
		}


		///////////////////////////   Display Results    ////////////////////////////
		System.out.println();
		System.out.println("Top student "+ student1 +"'s score is "+ score1);

	}
}
