using CompanyHierarchyProject.Interfaces;
using System.Collections.Generic;

namespace CompanyHierarchyProject
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sales> setOfSales;

        public SalesEmployee(string firstName, string lastName, int idNumber, decimal salary, Department department, List<Sales> setOfSales)
            : base(firstName, lastName, idNumber, salary, department)
        {
            this.SetOfSales = setOfSales;
        }

        public List<Sales> SetOfSales { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
