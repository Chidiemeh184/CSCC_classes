using System;
public class DemoObjectInitializer2
{
   public static void Main()
   {
     Box box1 = new Box {Height = 3};
     Box box2 = new Box {Width = 15};
     Box box3 = new Box {Depth = 268};
     DisplayDimensions(1, box1);
     DisplayDimensions(2, box2);
     DisplayDimensions(3, box3);
   }
   internal static void DisplayDimensions(int num, Box box)
   {
      Console.WriteLine("Box {0}: Height: {1} Width: {2} Depth: {3}",
        num, box.Height, box.Width, box.Depth);
   }
}
class Box
{
   public int Height {get; set;}
   public int Width {get; set;}
   public int Depth {get; set;}
   public Box()
   {
      Height = 1;
      Width = 1;
      Depth = 1;
   }
}
