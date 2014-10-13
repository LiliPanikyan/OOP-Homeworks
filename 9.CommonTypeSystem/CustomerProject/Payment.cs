using System;

namespace CustomerProject
{
    public class Payment
    {
        private string productName;
        private decimal productPrice;

        public Payment(string productName, decimal productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
