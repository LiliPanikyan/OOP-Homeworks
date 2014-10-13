using CompanyHierarchyProject.Interfaces;
using System.Collections.Generic;

namespace CompanyHierarchyProject
{
    public class Manager:Employee, IManager
    {
        private List<Employee> setOfEmployees;

        public Manager(string firstName, string lastName, int idNumber, decimal salary, Department department, List<Employee> setOfEmployees)
            :base(firstName, lastName, idNumber, salary, department)
        {
            this.SetOfEmployees = setOfEmployees;
        }

        public List<Employee> SetOfEmployees{ get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
