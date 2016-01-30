/**
 * Name: Chidi Emeh
 * 
 * Date: 10/22/2013
 * 
 * Program: TaxCalculation.cs
 * 
 * Description: This program calculates the tax for 
 *              a set of values using method overload. jjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj
 * 
 * */
using System;


class TaxCalculation
{
    private static double FindTax(double price, double taxRate)
    {
        double tax;
        tax = price * taxRate;
        return tax;
    }

    private static double FindTax(double price, int taxRate)
    {
        double tax;
        tax = price * (double)taxRate/100;
        return tax;
    }

    static void Main()
    {
        double tax1, tax2, price = 79.95, taxRate1= 0.06;
        int taxRate2 = 6;

        tax1 = FindTax(price, taxRate1);
        tax2 = FindTax(price, taxRate2);
        Console.WriteLine("For the price = {0:C} and tax rate = {1}, the tax amount is: {2:C}.", price, taxRate1, tax1);
        Console.WriteLine("For the price = {0:C} and tax = {1:F}%, the tax amount is: {2:C}.", price, taxRate2, tax2);
        Console.WriteLine();
        Console.WriteLine("Press the <Enter> key to terminate this program.");
        Console.ReadLine();
    }
}

