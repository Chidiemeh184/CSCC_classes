
/*
   Chapter 3   Assignment
   Programmer: Azar Haghi, Chidi Emeh, Wayne Drew
   Date: 09/25/2015
   Program Name:   CitySort.java
   Purpose: This program is to sort three cities in ascending order.
*/

import java.util.Scanner;

class NameSort
{
	public static void main(String[] args)
	{
		Scanner input = new Scanner(System.in);

		//Declare Variables
		String city1, city2, city3, userInput, temp;

		//Get user input
		System.out.print("Enter the first city: ");
		city1 = input.nextLine();
		System.out.print("Enter the second city: ");
		city2 = input.nextLine();
		System.out.print("Enter the third city: ");
		city3 = input.nextLine();
		System.out.println();

		/*
		   Check before sorting
		System.out.println("Before Sorting: ");
		System.out.println("First city: "+ city1);
		System.out.println("Second city: "+ city2);
		System.out.println("Third city: "+ city3);
		*/

		//Sort
		if (city1.compareTo(city2) > 0)
		{
			temp = city1;
			city1 = city2;
			city2 = temp;
		}

		if (city2.compareTo(city3) > 0)
		{
			temp = city2;
			city2 = city3;
			city3 = temp;
		}

		if (city1.compareTo(city2) > 0)
		{
			temp = city1;
			city1 = city2;
			city2 = temp;
		}
		System.out.println();
		/*
			Check after sorting
		System.out.println("After Sorting: ");
		System.out.println("First city:" + city1);
		System.out.println("Second city: "+ city2);
		System.out.println("Third city: "+ city3);
		*/

		//Display Result
		System.out.println("The three cities in alphabetical order are "+ city1 + " "+ city2+ " "+city3+ "." );
	}
}