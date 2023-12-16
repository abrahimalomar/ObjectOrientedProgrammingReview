using System;

namespace Polymorphism
{
    partial class Program
    {
        public class Car : IDrivable
        {
        public void Drivinginstructions()
        {
            Console.WriteLine("Follow the driving instructions for the car.");
        }
    }
    }
}

