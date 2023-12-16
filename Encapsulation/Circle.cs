using System;

namespace Encapsulation
{
    public class Circle 
    {
        public double Radius { get; set; }

        public void InsertRadius(double radius)
        {
            if (radius>0)
            {
                Radius = radius;
            }
            else
            {
                throw new Exception(" Radius must be greater than 0 ");
            }
        }
        public double GetRadius()
        {
            return Radius;
        }

        public  double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

}
