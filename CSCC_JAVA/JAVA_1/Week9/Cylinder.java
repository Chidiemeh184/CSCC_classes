/**
*Extra Credit
*Name: Chidi Emeh
*Date: 11/7/2015
*Program: This program creates a class cylinder
*		  with constructor overloads.
**/


public class Cylinder
{
	private double radius  = 1.0;
	private double height = 1.0;
	private double volume;

	public Cylinder()
	{

	}

	public Cylinder(double newRadius, double newHeight)
	{
		radius = newRadius;
		height = newHeight;
	}

	public double getRadius()
	{
		return radius;
	}

	public double getHeight()
	{
		return height;
	}

	public double getVolume()
	{
		volume = Math.PI * Math.pow(getRadius(), 2) * getHeight();
		return volume;
	}


}
