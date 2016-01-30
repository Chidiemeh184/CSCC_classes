/*
	Chapter :  The Body mass Index Calculator
	Programmer:  M Insabella
	Date:
	Filename:	 BodyMassApplet.java
	Purpose:	 This project calculates the body mass index based
				 on a person's height and weight.
				 */

import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class BodyMassApplet extends Applet implements ActionListener
{
		// declare variables

		int inches, pounds;
		double meters, kilograms, index;

		//construct components
		Label companyLabel = new Label("THE SUN FITNESS CENTER BODY MASS INDEX CALCULATOR");
		Label heightLabel = new Label("Enter your height to the nearest inch: ");
			TextField heightField = new TextField(10);
		Label weightLabel = new Label("Enter your weight to the nearest pound: ");
			TextField weightField = new TextField(10);
		Button calcButton = new Button("Calculate");
		Label outputLabel = new Label("Click the Calculate button to see your body mass index.");

		public void init()
		{
			setForeground(Color.red);
			add(companyLabel);
			add(heightLabel);
			add(heightField);
			add(weightLabel);
			add(weightField);
			add(calcButton);
			calcButton.addActionListener(this);
			add(outputLabel);

		}

		public void actionPerformed(ActionEvent e)
		{

			inches = Integer.parseInt(heightField.getText());
			pounds = Integer.parseInt(weightField.getText());
			meters = inches / 39.36;
			kilograms = pounds / 2.2;
			index = kilograms / Math.pow(meters,2);
			outputLabel.setText("YOUR BODY MASS INDEX IS " + Math.round(index) + ".");
		}


}