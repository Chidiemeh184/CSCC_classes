/*
   Chapter 8  Assignment
   Programmer: Chidi Emeh
   Date: 11/06/2015
   Program Name:  CarDemo.java
   Purpose:  This program creates a class CarDemo
   			 to demonstrate the capability of the class
   			 Car.
*/

import java.util.Scanner;

public class CarDemo
{
	public static void main(String[] args)
	{
		//////////////// Initialize Variable ///////////////
		int carYear;
		String carName;
		Scanner input = new Scanner(System.in);


		System.out.println("	Demonstration of Car Class");
		System.out.println("");
		System.out.print("Enter the make of the car: ");
		carName = input.nextLine();
		System.out.println("");
		System.out.print("Enter the year of the car: ");
		carYear = input.nextInt();


		/////////////// Check User Input ///////////////////////
		while( carYear < 1940 || carYear > 2015)
		{
			System.out.println("Input error - enter a year between 1940 and 2015");
			System.out.print("Enter the year of the car: ");
			carYear = input.nextInt();
	    }



			if (carYear >= 1940 && carYear <= 2015)
			{

				System.out.println("");


					Car demoCar =  new Car(carYear, carName);

						System.out.println("demoCar");
						System.out.println("  Model Year: " + demoCar.getYearModel());
						System.out.println("  Make      : " + demoCar.getMake());
						System.out.println("  Speed     : " + demoCar.getSpeed());
						System.out.println("");
						System.out.println("Speed UP!");
						System.out.println("");

						for(int i=0; i<5; i++)
							{
								demoCar.accelerate();
								System.out.println("demoCar's speed: "+ demoCar.getSpeed());
							}

								System.out.println("");
								System.out.println("Slow Down!");
								System.out.println("");
								for(int i=0; i<5; i++)
								 {
									demoCar.brake();
									System.out.println("demoCar's speed: "+ demoCar.getSpeed());
								}
									System.out.println("");
									System.out.println("");
			   System.out.println("End of the Road for Car Class Demonstration");

			}




	}
}