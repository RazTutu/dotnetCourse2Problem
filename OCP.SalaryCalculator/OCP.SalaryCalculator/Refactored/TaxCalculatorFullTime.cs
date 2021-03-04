using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.SalaryCalculator.Refactored
{
    public class TaxCalculatorFullTime : ITaxCalculator
    {
        public decimal CalculateTax(Employee employee)
        {
            return employee.Payment * 25 / 100;
        }
    }
}
