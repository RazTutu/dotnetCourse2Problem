using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.SalaryCalculator.Refactored
{
    public class TaxCalculatorContext
    {
        private Dictionary<EmployeeType, ITaxCalculator> strategies = new Dictionary<EmployeeType, ITaxCalculator>();

        public TaxCalculatorContext()
        {
            strategies.Add(EmployeeType.FULL_TIME, new TaxCalculatorFullTime());
            strategies.Add(EmployeeType.FREELANCE, new TaxCalculatorFreelance());
            strategies.Add(EmployeeType.PARTIAL_TIME_6H, new TaxCalculatorPartTimeSix());
        }

        public decimal compute(Employee employee)
        {
            return strategies[employee.employeeType].CalculateTax(employee);
        }
    }
}
