/*
	Chapter 6:	Sum Calculator
	Programmer: Chidi Emeh
	Date:		11/21/2015
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

	Label num2Label = new Label("Number 2:       ");
		TextField num2Field = new TextField(15);



	Label outputLabel = new Label("                                                        ");

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
		try
		{
			num1 = getNum1();
			num2 = getNum2();

				if((num1 < 1) && ((num2 >= 11)&&(num2 <= 20)))                           //only first number wrong (less than one)
				{
					throw new Exception(" Hey! Enter num1 greater than 1");
				}

				if((num1 > 10) && ((num2 >= 11)&&(num2 <= 20)))                          //only first number wrong (greater than 10)
				{
					throw new Exception(" Hey! Enter num1 less than 10");
				}

				if(((num1 >= 1) && (num1 <= 10)) && (num2 < 11))                        //only second number wrong (less than 11)
				{
					throw new Exception("		Hey! Enter num2 greater than 11");
				}

				if(((num1 >= 1) && (num1 <= 10)) && (num2 > 20))						//only second number wrong (greater than 20)
				{
					throw new Exception("		Hey! Enter num2 less than 20");
				}

				if(((num1 > 10) || (num1 < 1)) && ((num2 > 20) || (num2 < 11)))         //Both numbers are wrong
				{
					throw new Exception("		Hey!  Enter  from 1-10 for num1 and Enter from 11-20 for num2");
				}



			output(num1, num2);
		}

		catch(NumberFormatException ie)
		{
			outputLabel.setText("			Please Enter only digits");
			erazeField();
		}

		catch(Exception iee)
		{
			outputLabel.setText(iee.getMessage());
			erazeField();
		}

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

	public void erazeField()
	{
			num1Field.setText("");
			num1Field.requestFocus();
			num2Field.setText("");
			num2Field.requestFocus();

	}
}