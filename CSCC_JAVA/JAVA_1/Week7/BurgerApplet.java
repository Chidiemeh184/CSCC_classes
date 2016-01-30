/*
	Chapter 6:	Burger Applet
	Programmer:	Joseph Vergara, Chidi Emeh, Jennifer Mean
	Date:		10/17/2015
	Filename:	BurgerApplet.java
	Purpose:	This program calculates and displays the amount of
				a customer's order, the tax and the total of the
				order based on the user's input.
*/

import java.awt.*;
import java.applet.*;
import java.awt.event.*;
import java.text.DecimalFormat;

public class BurgerApplet extends Applet implements ActionListener
{
	//Create components for applet
		double cost, totalCost, tax;
		final double TAX_RATE = 0.06;
		DecimalFormat twoDigits = new DecimalFormat("$#,###.00");

		Label welcomeLabel = new Label("Welcome to Bill's Burger Stand Calculator");
		Label costLabel = new Label("Please enter the cost of the order:  ");
			TextField costField = new TextField(15);



		Label outputLabel = new Label("Click the Calculate button to display the total cost.");

		Button calcButton = new Button("Calculate");
		public void init()
			{
				setBackground(Color.yellow);
				setForeground(Color.blue);
				add(welcomeLabel);
				add(costLabel);
				add(costField);
				costField.requestFocus();
				add(calcButton);
				calcButton.addActionListener(this);
				add(outputLabel);
			}

	public void actionPerformed(ActionEvent e)
		{
			cost = Double.parseDouble(costField.getText());
			tax = cost * TAX_RATE;
			totalCost = cost + tax;
			outputLabel.setText("The cost of this order is "+twoDigits.format(cost)+" tax of "+twoDigits.format(tax)+
			" for a total cost of "+twoDigits.format(totalCost)+".");
		}

}