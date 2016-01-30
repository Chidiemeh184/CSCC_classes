/*
   Chapter 8  Assignment
   Programmer: Chidi Emeh
   Date: 09/19/2015
   Program Name:   Car.java
   Purpose: ******************************
*/


public class CarDemo
{
	public static void main(String[] args)
	{
		Car demoCar;
		demoCar =  new Car(1980, "Chevy");

		System.out.println("demoCar");
		System.out.println("  Model Year: " + demoCar.getYearModel);
		System.out.println("  Make      : " + demoCar.getMake);
		System.out.println("  Model Year: " + demoCar.getSpeed);
		System.out.println("");
		System.out.println("");
		System.out.println("Speed UP!");
		System.out.println("");
		System.out.println("");

		for(int i=0; i<5)
		{
			demoCar.accelerate();
			System.out.println("demoCar's speed: "+ demoCar.getSpeed());
		}

		System.out.println("");
		System.out.println("");
		System.out.println("Slow Down!");

		for(int i=0; i<5)
		{
			demoCar.brake();
			System.out.println("demoCar's speed: "+ demoCar.getSpeed());
		}
		System.out.println("");
		System.out.println("");
		System.out.println("End of the Road for Car Class Demonstration");
	}
}