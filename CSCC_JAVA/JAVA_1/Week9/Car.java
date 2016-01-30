/*
   Chapter 8  Assignment
   Programmer: Chidi Emeh
   Date: 11/06/2015
   Program Name:   Car.java
   Purpose: This program creates a class car with
   			different field attributes.
*/


public class Car
{
	private int yearModel;
	private String make;
	private int speed;


	public Car(int givenYearModel, String givenMake)
	{

		yearModel = givenYearModel;
		make = givenMake;
		speed = 0;


	}

	public int getYearModel()
	{
		return yearModel;
	}

	public String getMake()
	{
		return make;
	}

	public int getSpeed()
	{
		return speed;
	}

	public void accelerate()
	{
		speed = speed + 5;
	}

	public void brake()
	{
		speed = speed - 5;
	}

}