/*
	Chapter 9:	Using an Applet to Search an Array
	Programmers: Moses Byanyuma, Yuzana Kyaw, Chidi Emeh
	Date: 10/31/15
	Filename:	Login.java
	Purpose: This program searches two arrays for user input
*/

import java.applet.*;
import java.awt.*;
import java.awt.event.*;

public class Login extends Applet implements ActionListener
{
   //Declaring variables
   String id, password;
   boolean success;

	String[] idArray= {"Moses", "Yuzana", "Chidi", "Mary", "Bob", "Jimmy", "George", "Fammy"};
	String[] passwordArray = {"coolaide", "1234", "random", "there", "here", "best", "football", "soda"};


   //Create components for applet
   Label headerLabel = new Label("Please type your ID and Password");

   Label idLabel = new Label("ID:              ");
      TextField idField = new TextField(8);

   Label passwordLabel = new Label("Password:");
      TextField passwordField = new TextField(8);


   Button loginButton = new Button("Login");


   public void init()
   {
      //Set color, layout, and add components
      setBackground(Color.orange);

      setLayout(new FlowLayout(FlowLayout.LEFT,50,30));

      add(headerLabel);

      add(idLabel);
         add(idField);
         idField.requestFocus();

      add(passwordLabel);
         add(passwordField);
 		 passwordField.setEchoChar('*');

      add(loginButton);
         loginButton.addActionListener(this);
   }

   public void actionPerformed(ActionEvent e)
   {

      //Assigning data
      id = idField.getText();
      password = passwordField.getText();
      success = false;

      //Sequential search
		if((id.equals("")) || (password.equals("")))
		{
			headerLabel.setText("Enter data in both fields");
			repaint();

		}
		else
		{
			for(int i = 0; i < idArray.length; i++)
			{
				if((id.equals(idArray[i])) && (password.equals(passwordArray[i])))
				{

					success = true;
					break;
				}
			}
			if(success)
			{
				headerLabel.setText("Password accepted");
				repaint();
			}

			else
			{
					headerLabel.setText("Pasword failed");
					repaint();
			}


			}

		}






   public void repaint()
   {
	   idField.setText("");
	   passwordField.setText("");
	   idField.requestFocus();
   }
}