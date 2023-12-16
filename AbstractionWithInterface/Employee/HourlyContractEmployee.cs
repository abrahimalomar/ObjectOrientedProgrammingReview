using System;

namespace AbstractionWithInterface.Employee
{
    public class HourlyContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Hourly Contract Employee: {Name}");
        }

        public decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
