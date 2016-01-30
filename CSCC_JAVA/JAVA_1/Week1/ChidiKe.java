//*****************************************************
// Programming Challenge                              *
// Name: Chidi Emeh									  *
// Date: 09/05/2015                                   *
// File Name: ChidiKe.java                            *
// Description: This program declares variables of    *
//              different types and displays it.      *
//*****************************************************

//define class that contains the program
public class ChidiKe {

	//the file containing this code needs to be named NameInitials.java -
	// matching the name of the class (case sensitive) defined within it

		// method main is the starting point for all Java pograms

		public static void main(String[] args){
			//declare String variables to store programmer's first, middle
			//and last name

			String firstName;		//Programmer's first name
			String middleName;		//Programmer's middle name
			String lastName;		//Programmer's last name

			//declare char variables to store programmer's initials
			char firstInitial;		//Programmer's first initial
			char middleInitial;		//Programmer's middle initial
			char lastInitial;		//Programmer's last initial

			//initialize variables to hold programmer's name
			firstName = "Chidi";
			middleName = "King";
			lastName = "Emeh";
						//String literals are enclosed by double quotes

			//initialize variables to hold programmer's initials
			firstInitial = 'C';
			middleInitial = 'K';
			lastInitial = 'E';
							//char literals are enclosed by single quotes
							//NOTE: 'J' is not the same as "J"

			//Display the programmer full name and initials
			System.out.println("First Name: " + firstName);
			System.out.println("Middle Name: " + middleName);
			System.out.println("Last Name: " + lastName);

			//put a blank line between name and initials
			System.out.println();

			System.out.println("First Initial:  " + firstInitial);
			System.out.println("Middle Initial: " + middleInitial);
			System.out.println("Last Initial:  "  + lastInitial );
		}

}