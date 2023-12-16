using System;

namespace AbstractionWithInterface.Employee
{
    public class ContractEmployee : IEmployee
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }

        public void DisplayInformation()
        {
            Console.WriteLine($"Contract Employee: {Name}");
        }
        public decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
