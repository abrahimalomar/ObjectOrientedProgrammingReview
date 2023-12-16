using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Employee> list = new List<Employee>()
        {
            new ITEmployee(1, "Ibrahim Alomar", 1000, 20, "C#"),
            new ITEmployee(2, "Ibrahim Alomar", 5000, 0, "Java"),
            new ITEmployee(3, "Ibrahim Alomar", 2000, 10, "Dart"),
            new ITEmployee(4, "Ibrahim Alomar", 6000, 0, "Python"),
            new ITEmployee(5, "Ibrahim Alomar", 50, 0, "C++"),
            new ITEmployee(6, "Ibrahim Alomar", 1000, 20, "JS"),
            new FinanceEmployee(7, "Ibrahim alomar", 300, 0),
            new FinanceEmployee(8, "Ibrahim alomar", 300, -5),
            new FinanceEmployee(9, "Ibrahim alomar", 300, 0),
            new MarketingEmployee(12, "Ibrahim alomar",120,8),
            new SalesEmployee(13, "Ibrahim alomar", 150, 5, 20),
        };

        foreach (Employee employee in list)
        {
            Console.WriteLine($"Position : {employee.GetType().Name}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Salary: {employee.CalculateSalary()}");
            Console.WriteLine();
        }
    }
}

