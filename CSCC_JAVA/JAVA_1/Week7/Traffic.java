/*
	Chapter 6:	Traffic Ticket
	Programmer:	Chidi Emeh
	Date:		10/23/2015
	Filename:	Traffic.java
	Purpose:	This program calculates a traffic ticket and court costs.
*/

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class Traffic
{
	public static void main(String[] args)
	{
		//declare class variables
		double fine, courtCosts, ticket;
		int speedLimit, offenderSpeed, previousTickets, overLimit;
		System.out.println("       *****Ticket Calculator*****");


		//call methods

				speedLimit = getLimit();
				offenderSpeed = getDriverSpeed();
				if (offenderSpeed <= speedLimit)
				{
					JOptionPane.showMessageDialog(null,"No violation", "Traffic Ticket",JOptionPane.INFORMATION_MESSAGE);
					finish();
				}

				previousTickets = getTickets();
				overLimit = offenderSpeed - speedLimit;
				fine = overLimit * 20.00;
				courtCosts = getCosts(previousTickets);
				ticket = fine + courtCosts;
				output(fine, courtCosts, ticket);
				finish();
			}




	//The getLimit() method asks the user to input a the speed limit.
	public static int getLimit()
	{
		//declare method variables
		int limit = 0;
		String answer;

		answer = JOptionPane.showInputDialog(null, "Enter the speed limit: ");

		if (answer == null)
		{
			finish();
		}

		limit = Integer.parseInt(answer);
		while(limit < 0)
		{
			answer = "";
			JOptionPane.showMessageDialog(null,"Your entry must be an integer greater than 0.", "Error",JOptionPane.INFORMATION_MESSAGE);
			answer = JOptionPane.showInputDialog(null, "Enter the speed limit: ");
			limit = Integer.parseInt(answer);
		}

		return limit;
	}

	//The getDriverSpeed() method asks the user to input the offender's speed.
		public static int getDriverSpeed()
		{
			//declare method variables
			int speed = 0;
			String answer;

			answer = JOptionPane.showInputDialog(null, "Enter the offenders speed: ");

					if (answer == null)
					{
						finish();
					}

					speed = Integer.parseInt(answer);
					while(speed < 0)
					{
						answer = "";
						JOptionPane.showMessageDialog(null,"Your entry must be an integer greater than 0.", "Error",JOptionPane.INFORMATION_MESSAGE);
						answer = JOptionPane.showInputDialog(null, "Enter the offenders speed: ");
						speed = Integer.parseInt(answer);
					}

			return speed;
	}

	//The getTickets() method retrieves number of tickets.
	public static int getTickets()
	{
			//declare method variables
			int tickets = 0;
			String answer;

					answer = JOptionPane.showInputDialog(null, "Enter the number of previous tickets: ");

					if (answer == null)
					{
						finish();
					}

					tickets = Integer.parseInt(answer);
					while(tickets < 0)
					{
						answer = "";
						JOptionPane.showMessageDialog(null,"Your entry must be an integer greater than 0.", "Error",JOptionPane.INFORMATION_MESSAGE);
						answer = JOptionPane.showInputDialog(null, "Enter the number of previous tickets: ");
						tickets = Integer.parseInt(answer);
					}

			return tickets;
	}

	//The getCosts() method returns the court costs.
	public static double getCosts(int tickets)
	{
		double costs = 0.0;

		if (tickets <= 1)
		{
			costs = 74.80;
		}
		if (tickets == 2)
		{
			costs = 99.80;
		}
		if (tickets >= 3)
		{
			costs = 124.80;
		}

		return costs;
	}

	//The output() method displays the cost of the ticket.
	public static void output(double dFine, double dCost, double dTicket)
	{
		DecimalFormat twoDigits = new DecimalFormat("$#,###.00");
		String fine = twoDigits.format(dFine);
		String cost = twoDigits.format(dCost);
		String ticket = twoDigits.format(dTicket);

		JOptionPane.showMessageDialog(null, "Your fine of " + fine + " plus your court costs of " +cost+ " is " + ticket + ".","Traffic Ticket",JOptionPane.PLAIN_MESSAGE);

	}

	//The finish() method ends the program.
	public static void finish()
	{
		System.exit(0);
	}
}