/*
	Chapter :  Circumference Calculator
	Programmer:	 Chidi Emeh
	Date:		 10/10/2015
	Filename:	 CircumCalc.java
	Purpose:	 This project calculates the circumference
				 on a circle.
*/

import java.applet.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;

public class CircumCalc extends Applet implements ActionListener
{
		// declare variables
			double radius, circum;

		//construct components
		Label welcome = new Label("Welcome to the Circumference Calculator");
		Label radiusLabel = new Label("Please enter the radius of the circle: ");
			TextField radiusField = new TextField(5);

		Button calcButton = new Button("Calculate");
		Label outputLabel = new Label("Click the Calculate button to display circumference of the circle.");
		DecimalFormat twoDigits = new DecimalFormat("#,###.00");

		public void init()
		{
			setForeground(Color.black);
			setBackground(Color.gray);
			add(welcome);
			add(radiusLabel);
			add(radiusField);
			add(calcButton);
			calcButton.addActionListener(this);
			add(outputLabel);

		}

		public void actionPerformed(ActionEvent e)
		{
				radius = Double.parseDouble(radiusField.getText());
				circum = 2* Math.PI * radius;
				outputLabel.setText("The Circumference with a raduis of "+ twoDigits.format(radius) + " is " + twoDigits.format(circum) + ".");


		}


}