//*****************************************************
// Splash screen                                      *
// Name: Chidi Emeh									  *
// Date: 09/05/2015                                   *
// File Name: SplashScreen.java                       *
// Description: This program makes a splash screen    *
//              with student information              *
//*****************************************************

import java.util.Date;

public class SplashScreen{
	public static void main(String[] args){
		//Declare Variables
		Date date = new Date();
		String name = "Chidi Emeh";
		String address = " 400 Kent Drive, Columbus OH, 43026";
		String email =  "cemeh@student.cscc.edu";

		//Display Splash Screen
		System.out.println("******************************************************");
		System.out.println("*                                                    *");
		System.out.println("*                                                    *");
		System.out.println("*	NAME: "+ name+"                             *");
		System.out.println("*	ADDRESS: "+ address+" *");
		System.out.println("*	STUDENT EMAIL: "+ email+"        *");
		System.out.println("*	DATE: "+ date+"           *");
		System.out.println("*                                                    *");
		System.out.println("*                                                    *");
		System.out.println("******************************************************");
		System.out.println();
	}
}
