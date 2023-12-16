using System;

namespace AbstractionWithInterface.Employee
{
    public class FullTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Full-Time Employee: {Name}");
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

}
