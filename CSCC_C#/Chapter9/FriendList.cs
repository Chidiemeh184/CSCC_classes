/**
 * Name: Chidi Emeh
 * Date: 11/6/2015
 * File Name: FriendList.cs
 * Program: This program creates a class Friend that takes
 *          has several field for personal data viz; name
 *          phone number and birth date. Then an array of 
 *          objects of friend is created with the corresponding 
 *          field attributes printed. The array is sorted before 
 *          the final output.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class FriendList
    {
        public static void Main()
        {
            Console.WriteLine("For this exercise, you will enter data for just 2 friends.");
            Console.WriteLine();

            //Create Empty Array of 2 friends
            Friend[] arrayOfFriends = new Friend[2];
            
            //Create Friends Objects
            Friend friend1 = new Friend();
            Friend friend2 = new Friend();

            //Add friend object to Array
            arrayOfFriends[0] = friend1;
            arrayOfFriends[1] = friend2;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////            Get user input for each friend in the array                      ///////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i=0; i<arrayOfFriends.Length; i++)
            {

                Console.Write("Enter the first name of the friend number {0}: ", i+1);
                arrayOfFriends[i].Name = Console.ReadLine();
                Console.Write("Enter the phone number (aaa-bbbb) of the friend number {0}: ", i+1);
                arrayOfFriends[i].PhoneNumber = Console.ReadLine();
                Console.Write("Enter the birth Month (1-12) of the friend number {0}: ", i+1);
                arrayOfFriends[i].Month = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Enter the birth Day (1-31) of the friend number {0}: ", i+1);
                arrayOfFriends[i].Day = Convert.ToInt32(Console.ReadLine()); 
                Console.Write("Enter the birth Year (yyyy) of the friend number {0}: ", i+1);
                arrayOfFriends[i].Year = Convert.ToInt32(Console.ReadLine()); ;
                Console.WriteLine();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////                   Sorting the Array based on Name inputs                         ///////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Array.Sort(arrayOfFriends, delegate(Friend temp1, Friend temp2) {
                                        return temp1.Name.CompareTo(temp2.Name);});





            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////                       Display Result after Sorting                              ////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Displaying the friends' data sorted by Friend name.");
            Console.WriteLine();
            foreach(Friend person in arrayOfFriends)
            {
                Console.WriteLine("Name = " + person.Name + ".");
                Console.WriteLine("Phone = " + person.PhoneNumber + ".");
                Console.WriteLine("Birthdate = " + person.Month + "/" + person.Day + "/" + person.Year + ".");
                Console.WriteLine();
            }

            Console.WriteLine("Press the <Enter> key to terminate this program.");
            Console.ReadLine();
        }
    }
    
    class Friend
    {
        private string name;
        private string phoneNumber;
        private int month;
        private int day;
        private int year;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

    }
}
