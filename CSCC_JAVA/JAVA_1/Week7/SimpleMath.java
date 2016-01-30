/*
	Chapter :	In class #2
	Programmer:	Joseph Vergara, Chidi Emeh, Jennifer Mean
	Date:		10/17/2015
	Filename:	Simple Math
	Purpose:	This program prompts a user to enter two integer
				numbers and performs and displays simple math
				calculations.
*/

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class SimpleMath
{
		public static void main(String[] args)
		{
			int firstNum, secondNum;
			System.out.println("\tA SIMPLE MATH PROGRAM");

			firstNum = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter your first integer:"));
			secondNum = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter your second integer:"));
			JOptionPane.showMessageDialog(null,firstNum + " + " + secondNum + " = " +(firstNum + secondNum)+ "\n"
			+firstNum + " - " + secondNum + " = " +(firstNum - secondNum)+ "\n"
			+firstNum + " * " + secondNum + " = " +(firstNum * secondNum)+ "\n"
			+firstNum + " / " + secondNum + " = " +(firstNum / secondNum)+ "\n"
			,"Simple Math Calculator",JOptionPane.PLAIN_MESSAGE);

			System.exit(0);




		}
}