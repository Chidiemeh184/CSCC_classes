/*
	Chapter 6:	Lab 6 (Temperature Converter)
	Programmer:	Chidi Emeh
	Date:		10/23/2015
	Filename:	TempConverter.java
	Purpose:	This program calculates the temperature, given by the user, to
				either Fahrenheit or Celsius.
*/


import java.util.Scanner;
import java.text.DecimalFormat;

public class TempConverter
{
	public static void main(String[] args)
	{

		//////////// Declare Variables and Initialize Objects   /////////////
		Scanner input = new Scanner(System.in);
		double temperature, convertedTemperature;
		DecimalFormat oneDigit = new DecimalFormat("###.0");
		int numberOfConversions;


		//////////// Display Header  ////////////
		System.out.println("	Temperature Converter");
		System.out.println("-------------------------------------------");
		System.out.println(" ");
		System.out.print("How many conversions would you like to make: ");
		numberOfConversions = input.nextInt();
		System.out.println();
		System.out.println();



		///////////  Conversions  ////////////////
		for(int i=0; i < numberOfConversions; i++)
		{
			int typeOfConversion;

			System.out.printf("Conversion # %s", (i+1));
			System.out.println();
			System.out.println();
			System.out.println("To convert from celsius to fahrenheit type 1 ");
			System.out.print("  To convert from fahrenheit to celsius type 2: ");
			typeOfConversion = input.nextInt();

			switch (typeOfConversion)
			{
				case 1: System.out.println();
						System.out.print("Enter a celsius temperature: ");
						temperature = input.nextDouble();
						convertedTemperature = celsiusToFahrenheit(temperature);
						System.out.println();
						System.out.println("The celsius temperature of "+ temperature + " degrees is equal to "+ oneDigit.format(convertedTemperature) + " degrees fahrenheit");
						System.out.println();
						break;

				case 2: System.out.println();
						System.out.print("Enter a fahrenheit temperature: ");
						temperature = input.nextDouble();
						convertedTemperature = fahrenheitToCelsius(temperature);
						System.out.println();
						System.out.println("The fahrenheit temperature of "+ temperature + " degrees is equal to "+ oneDigit.format(convertedTemperature)+ " degrees fahrenheit");
						System.out.println();
						break;
			}
		}

	}

	////////////  Converts celsius to fahrenheit  ///////
	public static double celsiusToFahrenheit(double cels)
	{
		double fahrenheit;
		fahrenheit = cels * 1.8 + 32.0;
		return fahrenheit;
	}

	///////////// Converts fahrenheit to celsius  ////////
	public static double fahrenheitToCelsius(double fahr)
	{
		double celsius;
		celsius = (fahr - 32) / 1.8;
		return celsius;
	}
}
