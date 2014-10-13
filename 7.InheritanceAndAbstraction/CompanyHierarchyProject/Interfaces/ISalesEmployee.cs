using System.Collections.Generic;

namespace CompanyHierarchyProject.Interfaces
{
    public interface ISalesEmployee:IRegularEmployee
    {
        List<Sales> SetOfSales { get; set; }
    }
}
