using System;

class Employee
{
    public int EmployeeId { get; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    public double BonusPercentage { get; set; } = 0.0;

    public Employee(int employeeId, string name, double baseSalary, double bonusPercentage)
    {
        EmployeeId = employeeId;
        Name = name;
        BaseSalary = baseSalary;
        BonusPercentage = bonusPercentage;
    }

    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }

    public void IncreaseSalary(double amount)
    {
        if (amount >= 0)
        {
            BaseSalary += amount;
        }
    }

    public string GetEmployeeDetails()
    {
        return $"Employee ID: {EmployeeId}, Name: {Name}, Salary: {BaseSalary}";
    }

    public void PrintEmployeeDetails()
    {
        Console.WriteLine(GetEmployeeDetails());
    }
}

