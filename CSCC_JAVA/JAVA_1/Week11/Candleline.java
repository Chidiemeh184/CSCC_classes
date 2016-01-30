/*
	Assignment Lab 11:	Candleline
	Programmer:	Chidi Emeh
	Date:		12/11/2015
	Filename:	Candleline.java
	Purpose:	The program prompts a customer for the cost of a candle order
				and the type of shipping wanted. Then the total cost is displayed.

*/

import java.util.InputMismatchException;
import java.util.Scanner;
import java.text.DecimalFormat;

public class Candleline
{
	public static void main(String[] args)
	{
		double candleCost, shippingCost;

		int shippingType;

		//call methods
		System.out.println("		CandleLine - Candle Online");
		System.out.println("");
		candleCost = getCandleCost();
		System.out.println("");
		shippingType = getShippingType();
		System.out.println("");
		shippingCost = getShippingCost(candleCost, shippingType);
		System.out.println("");
		output(candleCost, shippingCost);

	}

	public static double getCandleCost()
	{
		//create boolean value
		boolean contInput = true;
		//create scanner
		Scanner input = new Scanner(System.in);

		double givenCandleCost = 0;

		while(contInput)
		{
			try
			{
				System.out.print("Enter the cost of the candle order:   ");
				givenCandleCost = input.nextDouble();

				if(givenCandleCost <= 0)
				{
					throw new InputMismatchException();
				}
				contInput = false;
			}


			catch(InputMismatchException e)
			{
				System.out.println("Error, enter a dollar amount greater than 0");
				input.nextLine();
			}
		}

		return givenCandleCost;

	}

	public static int getShippingType()
	{
		//create boolean value
		boolean contInput = true;
		//create scanner
		Scanner input = new Scanner(System.in);

		int givenShippingType = 0;

		while(contInput)
		{
			try
			{
				System.out.println("Enter the cost of the candle order:");
				System.out.println(" 1) Priority <Overnight> ");
				System.out.println(" 2) Express <2 business days> ");
				System.out.println(" 3) Standard <3 to 7 business days> ");
				System.out.print("   Enter type number: ");
				givenShippingType = input.nextInt();

				if((givenShippingType < 0) || (givenShippingType > 3))
				{
					throw new InputMismatchException();
				}
				contInput = false;
			}


			catch(InputMismatchException e)
			{
				System.out.println("");
				System.out.println("Error, enter a 1, 2 or 3");
				input.nextLine();
				System.out.println("");
			}
		}

		return givenShippingType;

	}

	public static double getShippingCost(double givenCost, int givenType)
	{
		//variables
		double  ship = 0.00;

		if ((givenCost > 100.00) || (givenType == 3))
		{
			ship = 0.00;
		}
		else
		{
			if(givenType == 1)

				ship = 16.95;


			if (givenType == 2)

				ship =  13.95;


			if (givenType ==3)

				ship = 7.95;
		}

	  return ship;
	}

	public static void output(double userCost, double userType)
	{
		double totalCost = userCost + userType;
		DecimalFormat currency = new DecimalFormat("$#,###.00");
		System.out.println("The candle cost of " + currency.format(userCost) + " plus shipping costs of " + currency.format(userType) + " equals " + currency.format(totalCost));
	}


}