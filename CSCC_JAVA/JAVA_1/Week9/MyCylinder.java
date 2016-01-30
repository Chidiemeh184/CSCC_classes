/**
*Extra Credit
*Name: Chidi Emeh
*Date: 11/7/2015
*Program: This program test the class cylinder.
*
**/

import java.util.Scanner;

public class MyCylinder
{
	public static void main(String[] args)
	{
		double myRadius, myHeight;
		Scanner input = new Scanner(System.in);

		Cylinder cylinder1 = new Cylinder();
		Cylinder cylinder2 = new Cylinder(4.0, 6.0);


		System.out.println("The volume of a cylinder with radius "+ cylinder1.getRadius()+ " and height " + cylinder1.getHeight()+ " is "+cylinder1.getVolume());
		System.out.println();
		System.out.println("The volume of a cylinder with radius "+ cylinder2.getRadius()+ " and height " + cylinder2.getHeight()+ " is "+cylinder2.getVolume());
		System.out.println();
		System.out.print("Enter a new radius ");
		myRadius = input.nextDouble();
		System.out.println();
		System.out.print("Enter a new height ");
		myHeight = input.nextDouble();
		Cylinder cylinder3 = new Cylinder(myRadius, myHeight);
		System.out.println();
		System.out.println("The volume of a cylinder with radius "+ cylinder3.getRadius()+ " and height " + cylinder3.getHeight()+ " is "+cylinder3.getVolume());
	}

}