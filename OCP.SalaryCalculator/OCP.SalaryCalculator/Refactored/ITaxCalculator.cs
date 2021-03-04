namespace OCP.SalaryCalculator.Refactored
{
    public interface ITaxCalculator
    {
        decimal CalculateTax(Employee employee);
    }
}