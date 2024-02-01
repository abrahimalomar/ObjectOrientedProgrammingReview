using System;

namespace Polymorphism
{
    partial class Program
    {
        public class Ship : IDrivable
        {
            public void Drivinginstructions()
            {
                Console.WriteLine("Follow the driving instructions for sailing the ship.");
            }
        }
    }
}

