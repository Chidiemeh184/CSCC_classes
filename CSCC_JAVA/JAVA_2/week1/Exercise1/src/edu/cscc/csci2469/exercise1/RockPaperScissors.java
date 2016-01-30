//===================================
// Columbus State Community College
// CSCI 2469 - Spring Semester 2016
// Assignment: Exercise 1
// Programmer: Chidi Emeh
//===================================
package edu.cscc.csci2469.exercise1;

import java.util.Random;
import java.util.Scanner;

/**
 * The famous game of rock-paper-scissors
 */
public class RockPaperScissors {
	/**Hold the random number generator instance*/
	private static Random random = new Random();
	
	/**Hold the scanner to get users input*/
	private static Scanner scanner = new Scanner(System.in);

	/**
	 * The private constructor so we cant make one of these
	 */
	private RockPaperScissors() {
		super();
	}

	/**
	 * Get choice from the computer
	 * @return the computer's choice
	 */
	private static String getMyChoice() {
		switch (random.nextInt(3)) {
		case 0:
			return "R";
		case 1:
			return "P";
		case 2:
			return "S";
		default:
			throw new IllegalStateException("Bug");
		}
	}
	
	/**
	 * Gets choice from the human
	 * @return human's choice
	 */
	private static String getYourChoice() {
		String response;
		while (true) {
			System.out.print("Make your selection [R=rock | P=paper | S=scissors | Q=quit]: ");
			response = scanner.nextLine().trim().toUpperCase();
			if ("R".equals(response) || "P".equals(response) || "S".equals(response)) {
				return response;
			} else if ("Q".equals(response)) {
				System.out.println("Finished");
				System.exit(0);
			} else {
				System.out.println("*** Invalid response - try again ***");
			}
		}
	}

	/**
	 * Conevrt choice to something more readable
	 * @param theChoice to be made by the human
	 * @return the readable value
	 */
	private static String toPrintable(String theChoice) {
		switch (theChoice) {
		case "R":
			return "Rock";
		case "P":
			return "Paper";
		case "S":
			return "Scissors";
		default:
			throw new IllegalStateException("Bug");
		}
	}
	
	/**
	 * the starting point
	 * @param args command-line arguments
	 */
	public static void main(String[] args) {
		while (true) {
			String myChoice = getMyChoice();
			String yourChoice = getYourChoice();
			System.out.println("    My choice   : " + toPrintable(myChoice));
			System.out.println("    Your choice : " + toPrintable(yourChoice));
			String choices = myChoice + yourChoice;
			switch (choices) {
			case "RR":
				System.out.println("    A Tie!");
				break;
			case "PR":
				System.out.println("    Paper covers Rock - you lose!");
				break;
			case "SR":
				System.out.println("    Rock smashes Scissors - you win!");
				break;
			case "RP":
				System.out.println("    Paper covers Rock - you win!");
				break;
			case "PP":
				System.out.println("    A Tie!");
				break;
			case "SP":
				System.out.println("    Scissors cuts Paper - you lose!");
				break;
			case "RS":
				System.out.println("    Rock smashes Scissors - you lose!");
				break;
			case "PS":
				System.out.println("    Scissors cuts Paper - you win!");
				break;
			case "SS":
				System.out.println("    A Tie!");
				break;
			default:
				System.out.println("    You found a bug!");
			}
		}
	}
}
