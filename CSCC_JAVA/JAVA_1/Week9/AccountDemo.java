/*
	Chapter 10:	Account program
	Programmer:	Chidi Emeh
	Date:		11/7/2015
	Filename:	AccountDemo.java
	Purpose:	This program tests the class Account.
*/

import java.util.Scanner;
import java.text.DecimalFormat;

public class AccountDemo {
  public static void main (String[] args) {
	  int acctID;
	  double acctBalance, annIntRate, withAmt, depAmt;
	  Scanner input = new Scanner(System.in);
	  DecimalFormat twoDigits = new DecimalFormat("$###,###.00");

	  System.out.println("   Bank Account Balance");
	  System.out.println();

	  System.out.print("Enter your account id: ");
	  acctID = input.nextInt();
	  System.out.println();

	  System.out.print("Enter your current Balance: ");
	  	  acctBalance = input.nextDouble();
	  System.out.println();

	  System.out.print("Enter your annual interest rate: ");
	  	  annIntRate = input.nextDouble();
	  System.out.println();

	  System.out.print("Enter any withdrawals: ");
	  	  	  withAmt = input.nextDouble();
	  System.out.println();

	  System.out.print("Enter any deposits: ");
	  	  	  depAmt = input.nextDouble();
	  System.out.println();


    Account account = new Account(acctID, acctBalance);
    Account.setAnnualInterestRate(annIntRate);

    account.withdraw(withAmt);
    account.deposit(depAmt);
    System.out.println("Balance for account # " +  account.getId() + " is " +twoDigits.format(account.getBalance()));

    System.out.println("Monthly interest is " + twoDigits.format(account.getMonthlyInterest()));

    System.out.println("This account was created at " +
      account.getDateCreated());
      System.out.println();
  }
}

