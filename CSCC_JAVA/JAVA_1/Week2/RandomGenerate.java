/*
	Chapter 2:
	Programmer:	Chidi Emeh
	Date:		September 12, 2015
	Filename:	RandomGenerate.java
	Purpose:	This project displays random numbers

*/

import java.util.Random;

public class RandomGenerate {
	public static void main (String[] args) {
		Random input = new Random();

		num1 = input.nextInt(50) + 10;
		System.out.println("For num1: " + num1);
	}
}