
using System.Collections.Generic;

namespace CompanyHierarchyProject.Interfaces
{
    public interface IManager:IEmployee
    {
        List<Employee> SetOfEmployees { get; set; }
    }
}
