using System;
namespace AbstractionWithInterface.Employee
{
    public class PartTimeEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }
        public void DisplayInformation()
        {
            Console.WriteLine($"Part-Time Employee: {Name}");
        }
        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
