class FinanceEmployee : Employee
{
    public FinanceEmployee(int employeeId, string name, double baseSalary, double bonusPercentage)
        : base(employeeId, name, baseSalary, bonusPercentage)
    {
    }
    public override double CalculateSalary()
    {
        double bonus = BonusPercentage >= 0 ? BaseSalary * BonusPercentage / 100 : 0;
        return base.CalculateSalary() + bonus;
    }
}

