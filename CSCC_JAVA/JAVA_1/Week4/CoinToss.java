
/*
   Chapter 3   Debugging Assignment
   Programmer: Azar Haghi, Chidi Emeh, Wayne Drew
   Date: 09/19/2015
   Program Name:   Bert,java
   Purpose: This program calculates the monthly payment for a car.
*/


import java.util.Scanner;
import java.util.Random;

public class CoinToss
{
	public static void main(String[] args)
	{
		Scanner input = new Scanner();
		Random rand = new Random();

		//Declare Variables
		int userGuess, randomGuess;

		//Generate Guess
		randomGuess = rand.nextInt(2);

		//Get User Input
		System.out.print("Guess head or tail? Enter 0 for head and 1 for tail: ");
		userGuess = input.nextInt();


		//Make Decision
		if(userGuess == randomGuess)
		{
			System.out.println("Correct Guess");
		}
		else if (userGuess == 0)
		{
			System.out.println("Sorry, it is a tail");
		}
		else
		{
			System.out.println("Sorry, it is a head")
		}
	}
}































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































/*
   Chapter 3       Debugging Assignment
   Programmer: Azar Haghi, Chidi Emeh, Wayne Drew
   Date: 09/19/2015
   Program Name: CoinToss.java
   Purpose: This program generates a random number and asks the user to make a guess.
*/

import java.util.Random;
import java.util.Scanner;

public class CoinToss
{
	public static void main (String[] args)
	{
		Scanner input = new Scanner(System.in);
		Random rand = new Random();

		//Declare Variables
		int userGuess, randomGuess;

		//Prompt User to enter a number
		System.out.print("Guess head or tail? Enter 0 for head and 1 for tail: ");
		userGuess = input.nextInt();

		//Generate a Random Number
		randomGuess = rand.nextInt(2);

		//Decision
		if (userGuess == randomGuess)
		{
			System.out.println("Correct Guess ");
		}
		else if (userGuess == 0)
		{
			System.out.println("Sorry, it is a tails");
		}
		else
		{
			System.out.println("Sorry, it is a heads");
		}
	}
}












