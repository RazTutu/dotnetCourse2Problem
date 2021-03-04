namespace OCP.SalaryCalculator.Refactored
{
    public class TaxCalculator : ITaxCalculator
    {
        public decimal CalculateTax(Employee employee)
        {
            decimal tax = 0.0M;
            switch (employee.employeeType)
            {
                case EmployeeType.FULL_TIME:
                    tax = employee.Payment * 25 / 100;
                    break;
                case EmployeeType.FREELANCE:
                    tax = employee.Payment * 5 / 100;
                    break;
                case EmployeeType.PARTIAL_TIME_6H:
                    tax = employee.Payment * 10 / 100;
                    break;
            }
            return tax;
        }

    }
}
