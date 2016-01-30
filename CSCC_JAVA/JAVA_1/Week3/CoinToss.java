
/*
   Chapter 3   In class lab
   Programmer: Azar Haghi, Chidi Emeh, Wayne Drew
   Date: 09/19/2015
   Program Name:   CoinToss.java
   Purpose: This program asks user to guess head or tail of a coin.
*/


import java.util.Scanner;
import java.util.Random;

public class CoinToss
{
	public static void main(String[] args)
	{
		//Initialize Objects
		Scanner input = new Scanner(System.in);
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
			System.out.println("Sorry, it is a head");
		}
	}
}


