using System;
public class TestCarpet
{
   public static void Main()
   {
      Carpet aRug = new Carpet();
      aRug.Width = 12;
      aRug.Length = 14;
      Console.Write("The {0} X {1} carpet ", aRug.Width, aRug.Length);
      Console.WriteLine("has an area of {0}", aRug.Area);
      Console.WriteLine("Our motto is: {0}", Carpet.MOTTO);
   }
}
class Carpet
{
   public const string MOTTO = "Our carpets are quality-made";
   private int length;
   private int width;
   private int area;
   public int Length
   {
      get
      {
         return length;
      }
      set
      {
         length = value;
         CalcArea();
      }
   }
   public int Width
   {
      get
      {
         return width;
      }
      set
      {
         width = value;
         CalcArea();
      }
   }
   public int Area
   {
      get
      {
        return area;
      }
   }
   private void CalcArea()
   {
      area = Length * Width;
   }
}
