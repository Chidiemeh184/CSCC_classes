/*
	Chapter :	Sales Calculator (Midterm 2)
	Programmer:	Chidi Emeh
	Date:		11/14/2015
	Filename:	SalesApplet.java
	Purpose:    For a given sale price, this program calculates
				the sales tax of an item.
*/


import java.applet.*;
import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;


public class SalesApplet extends Applet implements ActionListener
{
	//Create components for applet
	double item1, item2, item3,itemTotal, tax = 0.06, total, taxAmt;
	DecimalFormat twoDigits = new DecimalFormat("$#,###.00");

	Label titleLabel = new Label("                  Sales Tax Calculator            ");
	Label itemOneLabel = new Label("Item 1:            ");
		TextField itemOneField = new TextField(20);

	Label itemTwoLabel = new Label("Item 2:            ");
		TextField itemTwoField = new TextField(20);

	Label itemThreeLabel = new Label("Item 3:           ");
		TextField itemThreeField = new TextField(20);


	Label outputLabel = new Label("                                                                  ");

	Button calcButton = new Button("Calculate");

	public void init()
		{
			setBackground(Color.cyan);
			setForeground(Color.red);
			add(titleLabel);
			add(itemOneLabel);
			add(itemOneField);
			itemOneField.requestFocus();
			add(itemTwoLabel);
			add(itemTwoField);
			itemTwoField.requestFocus();
			add(itemThreeLabel);
			add(itemThreeField);
			itemThreeField.requestFocus();
			add(calcButton);
			calcButton.addActionListener(this);
			add(outputLabel);
		}

	public void actionPerformed(ActionEvent e)
		{
			itemTotal = getItem1() + getItem2() + getItem3();
			taxAmt = itemTotal * tax;
			total = itemTotal + taxAmt;
			output();
		}

		public double getItem1()
		{
			double temp;
			temp = Double.parseDouble(itemOneField.getText());
			return temp;
		}

		public double getItem2()
		{
			double temp;
			temp = Double.parseDouble(itemTwoField.getText());
			return temp;
		}

		public double getItem3()
		{
			double temp;
			temp = Double.parseDouble(itemThreeField.getText());
			return temp;
		}

		public void output()
		{
			outputLabel.setText("Sales = "+twoDigits.format(itemTotal)+" Tax =  "+twoDigits.format(taxAmt)+
			" Total = "+twoDigits.format(total)+".");
		}


}