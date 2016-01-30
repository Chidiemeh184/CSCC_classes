/*
	Chapter 6 :  Kilowatt Calculator
	Programmer:  Chidi Emeh
	Date:		 10/14/2015
	Filename:	 KilowattApplet.java
	Purpose:	 This project calculates the monthly cost
				 per kilowatt-hour in using an appliance
				 */

import java.applet.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;

public class KilowattApplet extends Applet implements ActionListener
{

	///////////////////       Declare variables and initialize objects     /////////////
	double cost, total, kilowattHours;
	DecimalFormat twoDigits = new DecimalFormat("$#,###.00");



	//////////////////             Construct Components                 /////////////////
	Label heading =  new Label("Welcome to the Appliance Energy Calculator");
	Label costLabel = new Label("Please enter the cost per kilowatt-hour: ");
		  TextField costField = new TextField(7);
	Label hourLabel = new Label("Please enter the kilowatt-hours consumed: ");
		  TextField hourField = new TextField(7);

	Button calcButton = new Button("Calculate");
		  Label outputLabel = new Label("Click the Calculate button to display the monthly energy cost.");

	public void init()
			{
				setForeground(Color.red);
				setBackground(Color.yellow);
				add(heading);
				add(costLabel);
				add(costField);
				add(hourLabel);
				add(hourField);
				add(calcButton);
				calcButton.addActionListener(this);
				add(outputLabel);

		}

	public void actionPerformed(ActionEvent e)
		{
			cost = Double.parseDouble(costField.getText());
			kilowattHours =Double.parseDouble(hourField.getText());
			total = cost * kilowattHours;
			outputLabel.setText("The monthly cost to operate this appliance is " + twoDigits.format(total) + ".");
		}

}