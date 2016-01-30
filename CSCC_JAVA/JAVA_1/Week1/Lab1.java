//*****************************************************
// Lab 1											  *
// Name: Chidi Emeh									  *
// Date: 09/05/2015                                   *
// File Name: Lab1.java                               *
// Description: This is the first java program for    *
//              this class. The recieve input and     *
//				and displays certain operation        *
//*****************************************************

import java.util.Scanner;

//define the class
public class Lab1 {

	public static void main(String[] args){
		//Declare Variables
			int firstInteger;
			int secondInteger;
			double firstReal;
			double secondReal;



			//Display Header Information
			System.out.println("*******************************************");
			System.out.println("*  This is my first Java program          *");
			System.out.println("*******************************************");
			System.out.println();
			System.out.println();



			//Receive Integer Input for first entry
			System.out.println("**       Integer arithmetic tests        **");
			System.out.println();
			System.out.println();
			System.out.print("Enter the first integer to test: ");
			Scanner input = new Scanner(System.in);
			firstInteger = input.nextInt();

			//Receive Integer Input for second entry
			System.out.print("Enter the second integer to test: ");
			secondInteger = input.nextInt();


			//Perform Arithmetic for Integer Inputs & Display
			System.out.println(firstInteger+ " + "+secondInteger+" = "+ (firstInteger + secondInteger));
			System.out.println(firstInteger+ " - "+secondInteger+" = "+ (firstInteger - secondInteger));
			System.out.println(firstInteger+ " * "+secondInteger+" = "+ (firstInteger * secondInteger));
			System.out.println(firstInteger+ " / "+secondInteger+" = "+ (firstInteger / secondInteger));
			System.out.println(firstInteger+ " % "+secondInteger+" = "+ (firstInteger % secondInteger));
			System.out.println();
			System.out.println();


			//Receive Real Input for first entry
			System.out.println("**        Real arithmetic tests           **");
			System.out.println();
			System.out.println();
			System.out.print("Enter the first real to test: ");
			firstReal = input.nextDouble();

			//Receive Real Input for second entry
			System.out.print("Enter the second real to test: ");
			secondReal = input.nextDouble();


			//Perform Arithmetic for Real Inputs & Display
			System.out.println(firstReal+ " + "+secondReal+" = "+ (firstReal + secondReal));
			System.out.println(firstReal+ " - "+secondReal+" = "+ (firstReal - secondReal));
			System.out.println(firstReal+ " * "+secondReal+" = "+ (firstReal + secondReal));
			System.out.println(firstReal+ " / "+secondReal+" = "+ (firstReal / secondReal));
			System.out.println();
			System.out.println();
	}
}