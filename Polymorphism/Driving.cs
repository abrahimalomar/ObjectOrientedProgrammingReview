using System.Collections.Generic;

namespace Polymorphism
{
    partial class Program
    {
        public class Driving
        {
    public List<IDrivable> drivables { get; set; } = new List<IDrivable>();
    public void Driv(List<IDrivable> drivables)
            {
                {
                    foreach (var driv in drivables)
                    {
                        driv.Drivinginstructions();
                    }
                }
            }
    
    }
    }
}

