/*
	Chapter 4:	Age Calculator
	Programmer:	Mary Insabella
	Date:		October 10, 2012
	Filename:	Age.java
	Purpose:	This applet calculates a persons age and checks to see if input
				is correct).
*/

import java.awt.*;
import java.applet.*;
import java.awt.event.*;

public class Age extends Applet implements ActionListener
{
	//Create components for applet
	int bYear, cYear, age;
	String name;
	Label titleLabel = new Label("                     Age Calculator            ");
	Label namePromptLabel = new Label("Name:  ");
		TextField nameField = new TextField(15);

	Label birthYearLabel = new Label("Year of birth:       ");
		TextField birthYearField = new TextField(4);

	Label currentYearLabel = new Label("Current year:             ");
		TextField currentYearField = new TextField(4);


	Label outputLabel = new Label("                                                                                                                ");

	Button calcButton = new Button("Calculate");
	public void init()
		{
			setBackground(Color.cyan);
			setForeground(Color.red);
			add(titleLabel);
			add(namePromptLabel);
			add(nameField);
			nameField.requestFocus();
			add(birthYearLabel);
			add(birthYearField);
			add(currentYearLabel);
			add(currentYearField);
			add(calcButton);
			calcButton.addActionListener(this);
			add(outputLabel);
		}

	//This method is triggered by the user clicking an option button
	public void actionPerformed(ActionEvent e)
	{

		if (nameField.getText().equals(""))
		{
			outputLabel.setText("			input a name");
			nameField.requestFocus();
		}

		else
		{
			try
			{
				bYear = Integer.parseInt(birthYearField.getText());
				cYear = Integer.parseInt(currentYearField.getText());

				if(cYear < bYear) throw new Exception("			Enter birth year first.");
				if(bYear <= 1900) throw new Exception("			Get serious");
				if(cYear <= 2012) throw new Exception("			Current year cannot be <= 2012");


				age = cYear - bYear;

				outputLabel.setText("    " + nameField.getText() + " is " + age + " years old.");
			}

			catch(NumberFormatException ie)
			{
				outputLabel.setText("			Enter year using four digits");
				clearField();
			}

			catch(Exception iee)
			{
				outputLabel.setText(iee.getMessage());
				clearField();
			}
		}

	}

	public void clearField()
	{
		birthYearField.setText("");
		currentYearField.setText("");
		birthYearField.requestFocus();
	}
}