//Name: Chidi Emeh
//Date: 09/05/2015
//File: Demo.java
//Description: enter two numbers and a sum.

import java.util.Scanner;

public class Demo {

	public static void main(String[] args){
		//This is the main method

		int num1, num2;
		Scanner input = new Scanner(System.in);
		System.out.println("   Adding numbers");
		System.out.println();
		System.out.print("Enter the first number: ");
		num1 = input.nextInt();
		System.out.println();

		System.out.print("Enter the second number: ");
		num2 = input.nextInt();
		System.out.println();

		System.out.println(num1+" + "+num2+" = "+(num1+num2));
		System.out.println();
	}
}