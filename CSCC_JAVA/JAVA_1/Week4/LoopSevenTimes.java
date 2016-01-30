/**
* Name: Chidi Emeh
* Date: 09/26/2015
* Program: LoopSevenTimes.java
* Description: This program loops for seven times, with an inner loop of
*			   seven times.
**/


public class LoopSevenTimes
{
	public static void main(String[] args)
	{
		int count = 0;

		for(int i = 1; i <= 7; i++)
		{
			for(int j = 1; j <= 7; j++)
			{
				System.out.println(i + " " + j);
				count++;
			}
		}
		System.out.println("The total number of all combinations is " + count);
	}
}