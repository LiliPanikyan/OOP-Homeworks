using System.Collections.Generic;

namespace CompanyHierarchyProject.Interfaces
{
    public interface IDeveloper:IRegularEmployee
    {
        List<Project> SetOfprojects { get; set; }
    }
}
