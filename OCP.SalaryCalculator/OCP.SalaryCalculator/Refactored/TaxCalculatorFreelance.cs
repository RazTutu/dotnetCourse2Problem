using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.SalaryCalculator.Refactored
{
    public class TaxCalculatorFreelance : ITaxCalculator
    {
        public decimal CalculateTax(Employee employee)
        {
            return employee.Payment * 5 / 100;
        }
    }
}
