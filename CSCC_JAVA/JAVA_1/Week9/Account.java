/*
	Chapter 10:	Account program
	Programmer:	Chidi Emeh
	Date:		11/7/2015
	Filename:	Account.java
	Purpose:	This program creates a class Account
				with multiple instance attributes and methods
*/

import java.util.Date;
public class Account
{
	private int id;
	private double balance;
	private static double annualInterestRate;
	private Date dateCreated = new Date();
	private double monthlyInterest;

	public Account(int givenId, double givenBalance)
	{
		id = givenId;
		balance = givenBalance;
	}

	public int getId()
	{
		return id;
	}

	public double getBalance()
	{
		return balance;
	}

	public Date getDateCreated()
	{
		return dateCreated;
	}

	public double getAnnualInterestRate()
	{
		return annualInterestRate;
	}

	public static void setAnnualInterestRate(double givenOne)
	{
		 annualInterestRate = givenOne;

	}

	public double getMonthlyInterest()
	{
		monthlyInterest =( getBalance() * getAnnualInterestRate())/12.00;
		return monthlyInterest;
	}

	public void withdraw(double withdrawAmount)
	{
		balance = getBalance() - withdrawAmount;
	}

	public void deposit(double depositAmount)
	{
		balance = getBalance() + depositAmount;
	}
}