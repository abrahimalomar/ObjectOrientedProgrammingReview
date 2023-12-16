using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            square.Height = 100;
            square.Width = 50;
            double area = square.GetArea();
            double perimeter = square.GetPerimeter();

            Console.WriteLine($"Area of the square: {area}");
            Console.WriteLine($"Perimeter of the square: {perimeter}");


        }
    }

}
