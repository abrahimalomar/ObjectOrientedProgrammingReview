using AbstractionWithInterface.Employee;
using System;

namespace AbstractionWithInterface
{
    //class Program
    //{

    //    // طريقة لعرض معلومات الموظف باستخدام واجهة IEmployee
    //    static void DisplayEmployeeInformation(IEmployee employee)
    //    {
    //        employee.DisplayInformation();
    //        Console.WriteLine($"Monthly Salary: {employee.CalculateSalary()}");
    //    }
    //}



    class Program
    {
        static void Main()
        {
            IShape shape1 = new Circle(5.5);
            IShape shape2 = new Rectangle(4.3, 6.2);

            Console.WriteLine("Area of the circle: " + shape1.GetArea());
            Console.WriteLine("Area of the rectangle: " + shape2.GetArea());

            Console.WriteLine("------------------------------------------");

            static void DisplayEmployeeInformation(IEmployee employee)
            {
                employee.DisplayInformation();
                Console.WriteLine($"Monthly Salary: {employee.CalculateSalary()}");
            }


            IEmployee fullTimeEmployee = new FullTimeEmployee { Name = "Ibrahim Alomar", MonthlySalary = 500 };
            IEmployee partTimeEmployee = new PartTimeEmployee { Name = "Ibrahim alomar", MonthlySalary = 250 };
            IEmployee contractEmployee = new ContractEmployee { Name = "Ibrahim alomar", MonthlySalary = 300 };
            IEmployee hourlyContractEmployee = new HourlyContractEmployee { Name = "ibrahim alomar", HourlyRate = 10, HoursWorked = 40 };


            DisplayEmployeeInformation(fullTimeEmployee);
            DisplayEmployeeInformation(partTimeEmployee);
            DisplayEmployeeInformation(contractEmployee);
            DisplayEmployeeInformation(hourlyContractEmployee);



        }
    }

    

}
