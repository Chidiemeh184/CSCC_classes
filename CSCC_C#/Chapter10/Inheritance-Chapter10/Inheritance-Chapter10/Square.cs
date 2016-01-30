using System;


    class Square : Rectangle
    {

        public Square (int height, int width) :  base(height, width)
        {
            if (height != width)
            {
                height = width;
            }
        }

        public Square (int height) : base(height, height)
        {

        }
    }

