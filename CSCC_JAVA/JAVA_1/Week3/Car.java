/*
   Chapter 8  Assignment
   Programmer: Chidi Emeh
   Date: 09/19/2015
   Program Name:   Car.java
   Purpose: ******************************
*/


public class Car
{
	private int yearModel;
	private String make;
	private int speed;


	public void Car(int givenYearModel, String givenMake)
	{
		yearModel = givenYearModel;
		make = givenMake;
		speed = 0;
	}

	public int getYearModel
	{
		return yearModel;
	}

	public String getMake
	{
		return make;
	}

	public int getSpeed
	{
		return speed;
	}

	public void accelerate
	{
		speed = speed + 5;
	}

	public void brake
	{
		speed = speed - 5;
	}

}