using System;

namespace AbstractClasses
{
    class Program
    {

        static void Main(string[] args)
        {
            Shape square = new Square() { Width = 5.5, Height = 7 };
            Console.WriteLine($"Area of the square (Width: {square.Width}, Height: {square.Height}): {square.GetArea()}");

            Shape rectangle = new Rectangle() { Width = 4, Height = 10 };
            Console.WriteLine($"Area of the rectangle (Width: {rectangle.Width}, Height: {rectangle.Height}): {rectangle.GetArea()}");

            Shape circle = new Circle() { Radius = 10 };
            Console.WriteLine($"Area of the Circle (Radius: {((Circle)circle).Radius}): {circle.GetArea()}");
        }

    }



}
