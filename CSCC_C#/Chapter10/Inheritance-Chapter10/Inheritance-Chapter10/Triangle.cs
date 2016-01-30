using System;

class Triangle : GeometricFigure
{
        public  Triangle (int height, int width): base(height , width)
        {

        }

        public override double ComputeArea()
        {
            return Convert.ToDouble((Height * Width) * 0.5);
        }

}

