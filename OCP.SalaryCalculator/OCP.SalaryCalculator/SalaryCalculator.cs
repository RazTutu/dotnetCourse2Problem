using OCP.SalaryCalculator.Refactored;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.SalaryCalculator
{
    public class SalaryCalculator
    {
        private readonly TaxCalculator taxCalculator;

        public SalaryCalculator(TaxCalculator taxCalculator)
        {
            this.taxCalculator = taxCalculator;
        }


        public Salary CalculateSalary(Employee employee)
        {
            var salary = new Salary();
            decimal tax = taxCalculator.CalculateTax(employee);
            salary.TaxDeduction = tax;
            return salary;
        }


    }
}
