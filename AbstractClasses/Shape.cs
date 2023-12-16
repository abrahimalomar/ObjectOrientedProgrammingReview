namespace AbstractClasses
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double GetArea();
    }
}
