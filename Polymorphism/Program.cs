using System.Collections.Generic;
using System;
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
            new Motorcycle(),
            new Ship(),
           

            };
            foreach (var item in drivables)
            {
                item.Drivinginstructions();
            }

          
            //Driving driving = new Driving();

            //driving.Driv(drivables);
        }
    }
}

