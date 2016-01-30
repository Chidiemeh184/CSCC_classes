/**
*
*
**/

public class LoopContinue
{
	public static void main(String[] args)
	{
		System.out.println("Loop Continue");

		for(int i = 1; i <= 10; i++)
		{
			if (i == 5)continue;
			{
				System.out.println("Iteration # " + i);
			}
		}
		System.out.println("--------------------------");

		System.out.println("Loop Break");

		for(int i = 1; i <= 10; i++)
					{
					  if (i == 5)break;
						{
						   System.out.println("Iteration # " + i);
						}
			}
	}
}