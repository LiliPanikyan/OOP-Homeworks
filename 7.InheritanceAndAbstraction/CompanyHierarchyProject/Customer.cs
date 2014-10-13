using CompanyHierarchyProject.Interfaces;
using System;

namespace CompanyHierarchyProject
{
    public class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(string firstName, string lastName, int idNumber, decimal netPurchaseAmount)
            :base(firstName, lastName, idNumber)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                this.netPurchaseAmount = ValidationMethods.ValidateMoneyValue(value);
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
