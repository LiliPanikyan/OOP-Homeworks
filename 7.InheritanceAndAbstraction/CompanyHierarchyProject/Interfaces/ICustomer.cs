﻿
namespace CompanyHierarchyProject.Interfaces
{
    public interface ICustomer:IPerson
    {
        decimal NetPurchaseAmount { get; set; }
    }
}
