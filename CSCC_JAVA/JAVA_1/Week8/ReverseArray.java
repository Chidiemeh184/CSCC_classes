
import java.util.Scanner;

public class ReverseArray
{
	public static void main(String[] args)
	{

		int userInput;
		Scanner input = new Scanner(System.in);

		int[] num = new int[10];

		System.out.println("Enter ten integer values: ");
		for (int i=0; i < num.length; i++)
		{
			userInput = input.nextInt();
			num[i] = userInput;
		}

		System.out.println();
		for(int i = num.length-1; i >=0 ; i--)
		{
			System.out.println(num[i]);
		}

 	}
}