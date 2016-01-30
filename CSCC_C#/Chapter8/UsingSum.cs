/**
 * Name: Chidi Emeh
 * 
 * Date: 10/22/2013
 * 
 * Program: UsingSum.cs
 * 
 * Description: This program find the sum of elements
 *              in an array or list using method 
 *              overloads.
 * 
 * */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UsingSum
{

    //This method Takes only Arrays and finds the sum
    private static int SumIntegers(int[] arrays)
    {
        int sum = 0;
        int[] tempArray = arrays;
        foreach (int value in tempArray)
            sum = sum + value;
        return sum;
    }

    //This method Takes only Lists and finds the sum
    private static int SumIntegers(ArrayList list)
    {
        int sum = 0;
        foreach(int values in list)
        {
            sum = sum + values;
        }
        return sum;
    }


    static void Main()
    {   
        //Initialize and assign first ArrayList
        ArrayList list1 = new ArrayList();
        list1.Add(9);

        //Initialize and assign second ArrayList
        ArrayList list2 = new ArrayList();
        list2.Add(12);
        list2.Add(8);
        list2.Add(42);

        //Initialize and assign third ArrayList
        ArrayList list3 = new ArrayList();
        list3.Add(-1);
        list3.Add(2);
        list3.Add(8);
        list3.Add(4);
        list3.Add(0);

        //Initialize and assign Array 
        int[] arrayNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        //Display Result
        Console.WriteLine("For the list = {0}, the sum of its elements is: {1}.", ConvertToString('(', ')', list1), SumIntegers(list1));
        Console.WriteLine("For the list = {0}, the sum of its elements is: {1}.", ConvertToString('(', ')', list2), SumIntegers(list2));
        Console.WriteLine("For the list = {0}, the sum of its elements is: {1}.", ConvertToString('(', ')', list3), SumIntegers(list3));
        Console.WriteLine("For the array = {0}, the sum of its elements is: {1}.", ConvertToString('[', ']', arrayNumbers), SumIntegers(arrayNumbers));
        Console.WriteLine();
        Console.WriteLine("Press the <Enter> key to terminate this program");
        Console.ReadLine();

    }

    //Helper method to convert elements in an array to string and add [] at beginning and end
    private static string ConvertToString(char openParenthesis, char closeParenthesis,  params int[] array)
    {
        StringBuilder buffer = new StringBuilder(openParenthesis.ToString());
        for (int i = 0; i < array.Length; i++ )
        {
            buffer.Append(array[i] + ", ");
        }
        //Remove the last, unneeded string: ", "
        buffer.Remove(buffer.Length -2, 2);
        buffer.Append(closeParenthesis.ToString());
        return buffer.ToString();
    }

    //Helper method to convert elements in a list to string and add () at beginning and end
    private static string ConvertToString(char openParenthesis, char closeParenthesis,  ArrayList list)
    {
        StringBuilder buffer = new StringBuilder(openParenthesis.ToString());
        for (int i = 0; i < list.Count; i++)
        {
            buffer.Append(list[i] + ", ");
        }
        //Remove the last, unneeded string: ", "
        buffer.Remove(buffer.Length - 2, 2);
        buffer.Append(closeParenthesis.ToString());
        return buffer.ToString();
    }
}

