/*
	Chapter :  Income to Debt Ratio Calculator (Midterm 2)
	Programmer:	Chidi Emeh
	Date:		11/14/2015
	Filename:	 TestDebtRatio.java
	Purpose:	 This project calculates the income to debt ratio
*/

import javax.swing.JOptionPane;
import java.text.DecimalFormat;


public class TestDebtRatio
{
			public static void main(String[] args)
			{
				// declare and construct variables
				String strMonthlyIncome, strMortgage, strAutoLoan, strOtherDebt;
				double monthlyIncome, mortgage, autoLoan, otherDebt, ratio;


				//print prompts and get input
				System.out.println("\tWelcome to the Income to Debt Calculator");
				strMonthlyIncome=JOptionPane.showInputDialog(null, "Enter your monthly income:");
					monthlyIncome = Double.parseDouble(strMonthlyIncome);
				strMortgage=JOptionPane.showInputDialog(null, "Enter your mortgage payment:");
					mortgage = Double.parseDouble(strMortgage);
				strAutoLoan=JOptionPane.showInputDialog(null, "Enter your auto payment:");
					autoLoan = Double.parseDouble(strAutoLoan);
				strOtherDebt=JOptionPane.showInputDialog(null, "Enter your other debt:");
					otherDebt = Double.parseDouble(strOtherDebt);

				 // calculations
				ratio =( mortgage + autoLoan + otherDebt )/ monthlyIncome;

				 // output
				DecimalFormat fourDigits = new DecimalFormat("#,####.###");
				 JOptionPane.showMessageDialog(null, "YOUR DEBT RATIO IS  " + fourDigits.format(ratio) + ".","Debt Ratio Calculator",JOptionPane.PLAIN_MESSAGE);

			System.exit(0);
		}


}