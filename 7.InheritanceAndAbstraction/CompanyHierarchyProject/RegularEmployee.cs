using CompanyHierarchyProject.Interfaces;

namespace CompanyHierarchyProject
{
    public class RegularEmployee: Employee, IRegularEmployee
    {
        public RegularEmployee(string firstName, string lastName, int idNumber, decimal salary, Department department)
            :base(firstName, lastName, idNumber, salary, department){}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
