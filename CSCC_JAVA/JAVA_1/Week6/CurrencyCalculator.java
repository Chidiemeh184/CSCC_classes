/*
    Chapter 6:   Currency Calculator
	Programmer:  Chidi Emeh
	Date:		 10/14/2015
	Filename:	 CurrencyCalculator.java
	Purpose:	 For a given amount in dollars, this program
				 converts the amount to a euro, pounds and rubles
				 equvalent.
*/

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class CurrencyCalculator
{
	public static void main(String[] args)
	{

		///////////////////////      Declare Variables   ///////////////////////////////
		double dollar, euros, pounds, rubles;
		DecimalFormat f = new DecimalFormat("#,###.00");


		///////////////////////      Print prompts and get input    ////////////////////
		System.out.println("\t Currency Calculator");
		dollar = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter your dollar amount: "));


		////////////////////////     Calculations      /////////////////////////////////
		euros = dollar * 0.91;
		pounds = dollar * 0.64;
		rubles = dollar * 61.73;


		////////////////////////     Output      /////////////////////////////////////////
 		JOptionPane.showMessageDialog(null,"YOUR DOLLAR AMOUNT OF "+f.format(dollar)+"\n is equal to "+f.format(euros)+" euros ,\n"+f.format(pounds)+" pounds\n and "+f.format(rubles)+" rubles.","Currency Calculator",JOptionPane.PLAIN_MESSAGE);

	   System.exit(0);
	}
}