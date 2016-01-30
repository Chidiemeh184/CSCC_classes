using System;

class Rectangle : GeometricFigure
    { 
        public  Rectangle (int height, int width): base(height , width)
        {

        }


        public override double ComputeArea()
        {
            return Height * Width;
        }

    }

