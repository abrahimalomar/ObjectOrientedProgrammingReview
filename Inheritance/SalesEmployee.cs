class SalesEmployee : Employee
{
    public double SalesCommission { get; set; }

    public SalesEmployee(int employeeId, string name, double baseSalary, double bonusPercentage, double salesCommission)
        : base(employeeId, name, baseSalary, bonusPercentage)
    {
        SalesCommission = salesCommission;
    }
    public override double CalculateSalary()
    {
        double bonus = BonusPercentage >= 0 ? BaseSalary * BonusPercentage / 100 : 0;
        return base.CalculateSalary() + bonus + SalesCommission;
    }
}

