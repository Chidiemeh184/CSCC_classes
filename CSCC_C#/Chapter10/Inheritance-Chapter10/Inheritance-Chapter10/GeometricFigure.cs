using System;

abstract class GeometricFigure
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int Area
        {
            get
            {
                return Area;
            }
        }

        public GeometricFigure (int height, int width)
        {
           Height = height;
           Width = width;
        }

        public abstract double ComputeArea();
    }

