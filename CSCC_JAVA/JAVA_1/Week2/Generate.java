/*
	Chapter 2:
	Programmer:	Chidi Emeh
	Date:		September 12, 2015
	Filename:	RandomGenerate.java
	Purpose:	This project displays random numbers and bubble sorts in Ascending order

*/

import java.util.Random;

public class Generate {
	public static void main (String[] args) {
		Random input = new Random();

		/////////////// Declare Variables ////////////////////////////////////////////////
		int num1, num2, num3, temp;

		/////////////// Generate 3 Random Numbers ///////////////////////////////////////
		num1 = input.nextInt(50) + 10;
		num2 = input.nextInt(25) + 1;
		num3 = input.nextInt(15) + 1;


		/////////////// Display Numbers before Sorting /////////////////////////////////
		System.out.println("Before Sorting");
		System.out.println("For num1: " + num1);
		System.out.println("For num2: " + num2);
		System.out.println("For num3: " + num3);
		System.out.println();


		/////////////// Bubble Sort to Ascending Numbers  ///////////////////////////////
		if (num1 > num2 ){
			temp = num1;
			num1 = num2;
			num2 = temp;
	}
		if (num2 > num3){
			temp = num2;
			num2 = num3;
			num3 = temp;
	}
	   if (num1 > num2){
		   temp = num1;
		   num1 = num2;
		   num2 = temp;
	  }

		/////////////// Display Numbers After Bubble sorting /////////////////////////////
		System.out.println("After Sorting");
		System.out.println("For num1: " + num1);
		System.out.println("For num2: " + num2);
		System.out.println("For num3: " + num3);
		System.out.println();
	}
}