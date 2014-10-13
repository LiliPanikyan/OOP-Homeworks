using System;

namespace CompanyHierarchyProject
{
    public class Sales
    {
        private string productName;
        private string date;
        private decimal price;

        public Sales(string productName, string date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = ValidationMethods.CheckForEmptyString(value);               
            }
        }

        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = ValidationMethods.ValidateDate(value);
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = ValidationMethods.ValidateMoneyValue(value);
            }
        }
    }
}
