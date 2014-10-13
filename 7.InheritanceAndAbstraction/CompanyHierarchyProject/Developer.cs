using CompanyHierarchyProject.Interfaces;
using System.Collections.Generic;

namespace CompanyHierarchyProject
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private List<Project> setOfProjects;

        public Developer(string firstName, string lastName, int idNumber, decimal salary, Department department, List<Project> setOfprojects)
            :base(firstName, lastName, idNumber, salary, department)
        {
            this.SetOfprojects = setOfprojects;
        }

        public List<Project> SetOfprojects { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
