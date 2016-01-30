/*
	Chapter :  The Body mass Index Calculator
	Programmer:  M Insabella
	Date:
	Filename:	 BodyMassSwing.java
	Purpose:	 This project calculates the body mass index based
				 on a person's height and weight.
				 */

import javax.swing.JOptionPane;

public class BodyMassSwing
{
			public static void main(String[] args)
			{
				// declare and construct variables

				int inches, pounds;
				double kilograms, meters, index;

				//print prompts and get input
				System.out.println("\tTHE SUN FITNESS CENTER BODY MASS INDEX CALCULATOR");

					inches = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter your height to the nearest inch:"));

					pounds = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter your weight to the nearest pount:"));

				 // calculations
				 meters = inches / 39.36;
				 kilograms = pounds / 2.2;
				 index = kilograms / Math.pow(meters,2);

				 // output
				 JOptionPane.showMessageDialog(null, "YOUR BODY MASS INDEX IS " + Math.round(index) +".","Body Mass Index Calculator",JOptionPane.PLAIN_MESSAGE);

			System.exit(0);
			}

}