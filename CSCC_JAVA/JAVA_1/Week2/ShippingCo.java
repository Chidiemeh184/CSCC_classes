/*
	Chapter 2:
	Programmer:	Chidi Emeh
	Date:		September 12, 2015
	Filename:	ShippingCo.java
	Purpose:	This project calculates the price of shipping in dollars
				based on the weight, in pounds, provided.

*/

import java.util.Scanner;

public class ShippingCo {

	public static void main (String[] args){
		Scanner input = new Scanner(System.in);

		////////////// Request User for Weight Input  ///////////////////////////////////////
		System.out.print("Enter package weight: ");
		float weight = input.nextFloat();
		System.out.println();


		////////////// Determines & Displays Cost based on Weight Input Ranges //////////////
		if ((weight > 0) && (weight <= 1)){
			System.out.println("The cost of shipping is $3.50");
		}
		else if ((weight > 1) && (weight <= 3)){
			System.out.println("The cost of shipping is $5.50");
		}
		else if ((weight > 3 ) && (weight <= 10)){
			System.out.println("The cost of shipping is $8.50");
		}
		else if ((weight > 10) && (weight <= 20)){
			System.out.println("The cost of shipping is $10.50");
		}
		else {
			System.out.println("The package cannot be shipped");
		}
	}
}