/*
	Chapter 2:
	Programmer:	Chidi Emeh
	Date:		September 12, 2015
	Filename:	DollarConverter.java
	Purpose:	This project requests a user for a dollar value
				and converts to euro, pounds or rubles.

*/

import java.util.Scanner;

public class DollarConverter {

	public static void main(String[] args)
		{
			//////////////////////////////// Display Header ////////////////////////////////////////////////
			System.out.println("                    Currency Converter");
			System.out.println();


			///////////////////////////////  Declare variables	////////////////////////////////////////////
			double euro, pound, ruble;


			//////////////////////////////// Request User to Enter Dollar Amount ///////////////////////////
			Scanner input = new Scanner(System.in);
			System.out.print("Enter the US dollar amount: ");
			double amount = input.nextDouble();
			System.out.println();
			System.out.println();


			//////////////////////////////// Display Choice for Conversion ////////////////////////////////
			System.out.println("Enter a 1 to convert to euros");
			System.out.println("Enter a 2 to convert to pounds");
			System.out.println("Enter a 3 to convert to rubles");
			System.out.println();
			System.out.println();

			//////////////////////////////// Request User to Enter Choice //////////////////////////////////
			System.out.print("Enter your conversion choice: ");
			int choice = input.nextInt();
			System.out.println();



			///////////////////////////////// Converts Dollar Values based on Choice ///////////////////////
			switch(choice) {
				case 1:
					euro = amount * 0.91;
					System.out.printf("The dollar amount of $%s is equal to %s euros ", amount, euro);
					break;

				case 2:
					pound = amount * 0.64;
					System.out.printf("The dollar amount of $%s is equal to %s pounds ", amount, pound);
					break;

				case 3:
					ruble = amount * 61.73;
					System.out.printf("The dollar amount of $%s is equal to %s rubles ", amount, ruble);
					break;
		}	System.out.println();
	}

}