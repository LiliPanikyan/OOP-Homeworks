using CompanyHierarchyProject.Interfaces;
using System;

namespace CompanyHierarchyProject
{
    public class Employee:Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public Employee(string firstName, string lastName, int idNumber, decimal salary, Department department)
            :base(firstName, lastName, idNumber)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = ValidationMethods.ValidateMoneyValue(value);
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
