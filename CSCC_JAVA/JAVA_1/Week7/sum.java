/*
	Chapter 6:	Sum Calculator
	Programmer:
	Date:
	Filename:	sum.java
	Purpose:	This applet uses methods to get numbers and output a sum).
*/

import java.awt.*;
import java.applet.*;
import java.awt.event.*;

public class sum extends Applet implements ActionListener
{
	//Create components for applet
	int num1, num2;
	Label titleLabel = new Label("                     Sum Calculator            ");
	Label num1Label = new Label("Number 1:  ");
		TextField num1Field = new TextField(15);

	Label num2Label = new Label("Number 2:  ");
		TextField num2Field = new TextField(15);



	Label outputLabel = new Label(" ");

	Button addButton = new Button("Add");
	public void init()
		{
			setBackground(Color.cyan);
			setForeground(Color.red);
			add(titleLabel);
			add(num1Label);
			add(num1Field);
			num1Field.requestFocus();
			add(num2Label);
			add(num2Field);
			add(addButton);
			addButton.addActionListener(this);
			add(outputLabel);
		}

	//This method is triggered by the user clicking an option button
	public void actionPerformed(ActionEvent e)
	{
		num1 = getNum1();
		num2 = getNum2();
		output(num1, num2);
	}

	public int getNum1()
	{
		return Integer.parseInt(num1Field.getText());
	}

	public int getNum2()
	{
		return Integer.parseInt(num2Field.getText());
	}

	public void output(int number1, int number2)
	{
		outputLabel.setText("The value of "+number1+" + "+number2+" = "+(number1 + number2)+".");
	}
}