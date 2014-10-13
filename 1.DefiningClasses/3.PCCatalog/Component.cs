using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    
        public class Component
        {
            private string name;
            private decimal price;
            private string details;

            public string Name
            {
                get
                {
                    return this.name;
                }
                set
                {
                    ValidateData.checkStringsValue(value, "name");
                    this.name = value;
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
                    ValidateData.checkNumbersValue(value, "price");
                    this.price = value;
                }
            }
            public string Details
            {
                get
                {
                    return this.details;
                }
                set
                {
                    ValidateData.checkStringsValue(value, "details");
                    this.details = value;
                }
            }
            public Component(string name, decimal price, string details)
            {
                this.Name = name;
                this.Price = price;
                this.details = details;
            }
        }
    }

