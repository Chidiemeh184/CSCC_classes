/*
   Chapter 3   Assignment
   Programmer: Chidi Emeh
   Date: 09/19/2015
   Program Name:   Payroll.java
   Purpose: This program calculates the net pay of an employee
*/

import java.util.Scanner;
import java.text.DecimalFormat;

public class Payroll
{
	public static void main(String[] args)
	{
		////////////// Initialize Objects /////////////////
		Scanner input = new Scanner(System.in);
		DecimalFormat twoDigits = new DecimalFormat("$#,###.00");


		////////////// Declare Variables ///////////////////////////////////
		String name;
		double hoursWorked, fedTaxPerCent, stateTaxPerCent;
		double fedTax, stateTax, payRate, grossPay, deductions, tax, netPay;


		//////////// Display Header /////////////////////////////
		System.out.println("         Payroll Record           ");
		System.out.println();


		////////// Get User Input /////////////////////////////////////
		System.out.print("Enter employee's name: ");
		name = input.nextLine();
		System.out.print("Enter number of hours worked in a week: ");
		hoursWorked = input.nextDouble();
		System.out.print("Enter hourly pay rate: ");
		payRate = input.nextDouble();
		System.out.print("Enter federal tax withholding rate: ");
		fedTax = input.nextDouble();
		System.out.print("Enter state tax withholding rate: ");
		stateTax = input.nextDouble();
		System.out.println();


		////////// Calculations /////////
		grossPay = payRate * hoursWorked;

		fedTaxPerCent = fedTax * 100;                                 //converts federal tax withholdings
		String fws = fedTaxPerCent + "%";                           //to a string and adds percent sign.
		fedTax = fedTax * grossPay;

		stateTaxPerCent = stateTax * 100;                          //converts state tax withholdings to
		String sws = stateTaxPerCent + "%";                       //to a string and adds percent sign.
		stateTax = stateTax * grossPay;

		tax = fedTax + stateTax;
		netPay = grossPay - tax;


		//////// Display Results //////////
		System.out.printf("Employee Name: %s \n", name);
		System.out.printf("Hours Worked: %s \n", hoursWorked);
		System.out.printf("Pay Rate: %s \n", twoDigits.format(payRate));
		System.out.printf("Gross Pay: %s \n", twoDigits.format(grossPay));
		System.out.println("Deductions: ");
		System.out.printf("  Federal Withholding    <%s>:  %s \n", fws, twoDigits.format(fedTax));
		System.out.printf("  State Withholding      <%s>:  %s \n", sws, twoDigits.format(stateTax));
		System.out.printf("  Total Deduction:        %s \n", twoDigits.format(tax));
		System.out.printf("Net Pay:    %s  \n", twoDigits.format(netPay));


	}
}