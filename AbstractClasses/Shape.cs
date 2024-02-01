using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double GetArea();
    }
    public class Circell : Shape
    {
        public int R { get; set; }
        public override double GetArea()
        {
            return R*R*Math.PI;
        }
    }
    public class Red : Shape
    {
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
