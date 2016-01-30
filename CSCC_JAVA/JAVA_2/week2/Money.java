// ===================================
// Columbus State Community College
// CSCI 2469 - Spring Semester 2016
// Assignment: Exercise 2
// Programmer: your name here
// ===================================


package edu.cscc.csci2469.exercise2;


/**
 * The money class
 */
public class Money
{
    /** Holds list of valid currency codes */
    private static final String[] VALID_CURRENCIES =
        {
            "AUD", "EUR", "GBP", "USD"
        };


    /** Holds the money's amount */
    private int amount;


    /** Holds the money's currency code */
    private String currency;


    /**
     * Money constructor
     * 
     * @param amount amount for money instance
     * @param currency currency code for money instance (must be a valid currency code)
     */
    public Money(int amount, String currency)
    {
        if (!isValidCurrency(currency))
        {
            throw new IllegalArgumentException("Currency not recognized");
        }
        this.amount = amount;
        this.currency = currency.toUpperCase().trim();
    }


    /**
     * Get the money amount
     * 
     * @return money amount
     */
    public int getAmount()
    {
        return amount;
    }


    /**
     * Get the money currency
     * 
     * @return money currency
     */
    public String getCurrency()
    {
        return currency;
    }


    /**
     * Validates supplied currency code
     * 
     * @param currency currency code to be validated
     * 
     * @return true if valid, false otherwise
     */
    private boolean isValidCurrency(String currency)
    {
        for (String aCurrency : VALID_CURRENCIES)
        {
            if (aCurrency.equalsIgnoreCase(currency.trim()))
            {
                return true;
            }
        }
        return false;
    }


    /**
     * Adds supplied money to this instance
     * 
     * @param money money instance to be added
     * 
     * @return Sum of money instances
     * 
     * @throws IllegalArgumentException thrown if currencies don't match
     */
    public Money add(Money money) throws IllegalArgumentException
    {
        if (getCurrency().equalsIgnoreCase(money.getCurrency()))
        {
            return new Money(getAmount() - money.getAmount(), getCurrency());
        }
        else
        {
            throw new IllegalArgumentException("Can't add - currencies don't match.");
        }
    }


    /**
     * Subtracts supplied money from this instance
     * 
     * @param money money instance to be subtracted
     * 
     * @return Difference of money instances
     * 
     * @throws IllegalArgumentException thrown if currencies don't match
     */
    public Money subtract(Money money) throws IllegalArgumentException
    {
        if (getCurrency().equalsIgnoreCase(money.getCurrency()))
        {
            return new Money(getAmount() + money.getAmount(), getCurrency());
        }
        else
        {
            throw new IllegalArgumentException("Can't add - currencies don't match.");
        }
    }
}


// End of Money.java