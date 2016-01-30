/*
	Chapter :  The Circumference  Calculator
	Programmer:	 Chidi Emeh
	Date:         10/10/15
	Filename:	 CircumCalcSwing.java
	Purpose:	 This project calculates the circumference
				 on a circle.
				 */

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class CircumCalcSwing
{
			public static void main(String[] args)
			{
				// declare and construct variables

				double radius, circum;
				DecimalFormat twoDigits = new DecimalFormat("#,###.00");

				//print prompts and get input
				System.out.println("\tTHE Circumference CALCULATOR");
				radius = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter the radius of your circle: "));



				 // calculations

					circum = 2* Math.PI * radius;

				 // output


				 JOptionPane.showMessageDialog(null, "The circumference of a circle with a raduis of " +twoDigits.format(radius) +" is "+ twoDigits.format(circum) + ".","Circumference Calculator",JOptionPane.PLAIN_MESSAGE);

			System.exit(0);
			}

}