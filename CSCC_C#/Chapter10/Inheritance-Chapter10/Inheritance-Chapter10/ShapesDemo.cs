using System;

class ShapesDemo
{
    public static void Main(String[] args)
    {
        int input;

        Console.WriteLine();
        DisplayInfo();
        input = Convert.ToInt32(Console.ReadLine());

        while(input != 0)
        {
            switch(input)
            {
                case 1:
                    String shape = "Rectangle";
                    int tempH, tempW;

                    Console.WriteLine();
                    Console.Write("Enter the height of the rectangle: ");
                    tempH = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the width of the rectangle: ");
                    tempW = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Rectangle tempRectangle = new Rectangle(tempH, tempW);
                    Console.WriteLine("The shape is a: {0}", shape);
                    Console.WriteLine("The shape's height is: {0}", tempRectangle.Height);
                    Console.WriteLine("The shape's width is: {0}", tempRectangle.Width);
                    Console.WriteLine("The shape's area is: {0}", tempRectangle.ComputeArea());

                    break;
                case 2:
                    String shape2 = "Square";
                    int tempH2;

                    Console.WriteLine();
                    Console.Write("Enter the height of the square: ");
                    tempH2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Square tempSquare = new Square(tempH2);
                    Console.WriteLine("The shape is a: {0}", shape2);
                    Console.WriteLine("The shape's height is: {0}", tempSquare.Height);
                    Console.WriteLine("The shape's width is: {0}", tempSquare.Width);
                    Console.WriteLine("The shape's area is: {0}", tempSquare.ComputeArea());
                    break;
                case 3:
                    String shape3 = "Triangle";
                    int tempH3, tempW3;

                    Console.WriteLine();
                    Console.Write("Enter the height of the triangle: ");
                    tempH3 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the width of the triangle: ");
                    tempW3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Triangle tempTriangle = new Triangle(tempH3, tempW3);
                    Console.WriteLine("The shape is a: {0}", shape3);
                    Console.WriteLine("The shape's height is: {0}", tempTriangle.Height);
                    Console.WriteLine("The shape's width is: {0}", tempTriangle.Width);
                    Console.WriteLine("The shape's area is: {0}", tempTriangle.ComputeArea());

                    break;
            }
            
            Console.WriteLine();
            DisplayInfo();
            input = Convert.ToInt32(Console.ReadLine());
            
        }
        Console.WriteLine();
        Console.WriteLine("Press the <Enter> key to terminate this program.");
        Console.ReadLine();
    }

    public static void DisplayInfo()
    {
        Console.WriteLine("Choose a shape from the following options:");
        Console.WriteLine("[1] Rectangle");
        Console.WriteLine("[2] Square");
        Console.WriteLine("[3] Triangle");
        Console.Write("Enter the option number (or zero to terminate this program): ");
    }
}
