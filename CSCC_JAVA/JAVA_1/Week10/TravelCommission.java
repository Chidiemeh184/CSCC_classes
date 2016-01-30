/*
	Assignment Lab 10:	Commission Totals
	Programmer:	Chidi Emeh
	Date:		11/29/2015
	Filename:	TravelCommission.java
	Purpose:	This program calculates the sales commission for a travel agency
				The commission is based on different type of sales, provided by
				the user, and an error is thrown when a wrong input is given.
*/

import javax.swing.JOptionPane;
import java.text.DecimalFormat;

public class TravelCommission
{
	public static void main(String[] args)
	{

		//Declare Variables
		double dollars, answer;
		int empCode;

		dollars = getSales();
		empCode = getCode();

		answer = getComm(dollars, empCode);

		output(dollars, answer);

		finish();

	}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////       GET SALES  METHOD    ///////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static double getSales()
		{
			//declare method variables
			double sales = 0.00;
			String userInput;

			userInput = JOptionPane.showInputDialog(null, "Enter the sales amount\n(do not use commas or dollar signs)\nor click Cancel to exit: ");

			while(userInput != null)
				{
					try
					{
						sales = Integer.parseInt(userInput);
						if (sales <= 0)
						{
							userInput = "";
							throw new Exception();

						}
						else
						{
							break;
						}

					} // end try

					catch (NumberFormatException ie)
					{
						userInput = "";
						JOptionPane.showMessageDialog(null,"Error - Enter a number greater than 0.", "Error",JOptionPane.INFORMATION_MESSAGE);
					}

					catch (Exception iee)
					{
						userInput = "";
						JOptionPane.showMessageDialog(null,"Error - Enter only numbers greater than 0.", "Error",JOptionPane.INFORMATION_MESSAGE);
					}

						userInput = JOptionPane.showInputDialog(null, "Enter the sales amount\n(do not use commas or dollar signs)\nor click Cancel to exit: ");

				}//end of while loop

				if (userInput == null)
				{
					finish();
				}

				return sales;

		}//end of getSales() method

	    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////       GET CODE  METHOD    ////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static int getCode()
		{
			//declare method variables
			int code = 0;
			String userInput;

			userInput = JOptionPane.showInputDialog(null, "Enter the commission code: \n\n1)Telephone Sales\n2)In-Store Sales\n3)Outside Sales\n ");

			while(userInput != null)
			{
			    try
				{
						code = Integer.parseInt(userInput);
						if ((code != 1) && (code != 2) && (code != 3))
					{
						userInput = "";
						throw new Exception();
					}
					else
					{
						break;
					}

				}//end try

				catch (NumberFormatException ie)
				{
					userInput = "";
					JOptionPane.showMessageDialog(null,"Please enter a 1, 2, or 3.", "Error",JOptionPane.INFORMATION_MESSAGE);
				}

				catch (Exception iee)
				{
					userInput = "";
					JOptionPane.showMessageDialog(null,"Please enter a 1, 2, or 3.", "Error",JOptionPane.INFORMATION_MESSAGE);
				}

				userInput = JOptionPane.showInputDialog(null, "Enter the commission code: \n\n1) Telephone Sales\n2) In-Store Sales\n3) Outside Sales\n ");

			}//end while

			if (userInput == null)
			{
				finish();
			}

			return code;

		}//end of method getCode()

		///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////       GET COMMISSION  METHOD    //////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static double getComm(double amountInDollars, int theSaleCommissionType)
	  	{
				//declare method variables
			double commission = 0.00;

				if(theSaleCommissionType == 1)
				{
					commission = amountInDollars * 0.10;
				}

				else if(theSaleCommissionType == 2)
				{
					commission = amountInDollars * 0.15;
				}

				else
				{
					commission = amountInDollars * 0.18;
				}

				return commission;
	   }



	 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     ////////////////////////////////////////////       DISPLAY OUTPUT	    ///////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public static void output(double dollarAmount,  double commissionAmount)
	{
		DecimalFormat twoDigits = new DecimalFormat("$#,###.00");
		String dollar1 = twoDigits.format(dollarAmount);
		String commission1 = twoDigits.format(commissionAmount);

		JOptionPane.showMessageDialog(null, "Your commission on sales of " + dollar1 + " is " + commission1 + " ","Commission Totals",JOptionPane.PLAIN_MESSAGE);

	}


   ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
   ////////////////////////////////////////////       FINISH  METHOD    //////////////////////////////////////////////////////
   ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

	public static void finish()
	{
		System.exit(0);
	}
}