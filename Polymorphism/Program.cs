using System.Collections.Generic;

namespace Polymorphism
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<IDrivable> drivables = new List<IDrivable>()
            {
            new Motorcycle(),
            new Car(),
            new Airplane(),
            new Ship()

            };
            Driving driving = new Driving();
            driving.Driv(drivables);
        }
    }
}

