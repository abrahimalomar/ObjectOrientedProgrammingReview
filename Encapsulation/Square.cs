using System;

namespace Encapsulation
{
    public class Square
    {
       
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be greater than 0");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be greater than 0");
                }
                else
                {
                    height = value;
                }
            }
        }

        private double width;
        private double height;

      
        public double GetArea() => Width * Height;
        public double GetPerimeter() => 2 * (Width + Height);
    }

}
