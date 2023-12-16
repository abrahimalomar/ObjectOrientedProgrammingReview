class ITEmployee : Employee
{
    public string ProgrammingLanguage { get; set; }

    public ITEmployee(int employeeId, string name, double baseSalary, double bonusPercentage, string programmingLanguage)
        : base(employeeId, name, baseSalary, bonusPercentage)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public override double CalculateSalary()
    {
        double bonus = BonusPercentage >= 0 ? BaseSalary * BonusPercentage / 100 : 0;
        return base.CalculateSalary() + bonus;
    }
}

