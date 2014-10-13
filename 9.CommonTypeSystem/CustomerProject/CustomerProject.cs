using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerProject
{
    public class CustomerProject
    {
        static void Main(string[] args)
        {
            List<Payment> ivanIvanovPayments = new List<Payment>()
                {
                    new Payment("banana", 5.50m),
                    new Payment("orange", 2.60m),
                    new Payment("milk", 4.50m)
                };

            Customer ivanIvanov = new Customer(
                "Ivan",
                "Ivanov",
                "Ivanov",
                "9012098789",
                "Sofia, Pirotska str 18",
                "+359888898898",
                "ivan_ivanov@gmail.com",
                ivanIvanovPayments,
                CustomerType.Regular);

            Console.WriteLine("ORIGINAL\n" + ivanIvanov.ToString());

            List<Payment> clonedCustomerPayments = new List<Payment>()
                {
                    new Payment("milk", 5.50m),
                    new Payment("apple", 2.60m),
                };

            Customer clonedCustomer = (Customer)ivanIvanov.Clone();
            clonedCustomer.FirstName = "Pesho";
            clonedCustomer.MiddleName = "Peshev";
            clonedCustomer.LastName = "Ivanov";
            clonedCustomer.CustomerID = "9012098769";
            clonedCustomer.CustomerPayments = clonedCustomerPayments;
            clonedCustomer.TypeCustomer = CustomerType.OneTime;

            Console.WriteLine("CLONING\n" + clonedCustomer.ToString());
            Console.WriteLine("ORIGINAL AFTER CLONING\n" + ivanIvanov.ToString());

            Console.WriteLine("Compare customers with:");
            Console.WriteLine("Equal() method --> " + ivanIvanov.Equals(clonedCustomer));
            Console.WriteLine("== operator -->" + (ivanIvanov == clonedCustomer));
            Console.WriteLine("!= operator -->" + (ivanIvanov != clonedCustomer)+ "\n");

            Console.WriteLine("Original customer hash value --> " + ivanIvanov.GetHashCode());
            Console.WriteLine("Cloned customer hash value --> " + clonedCustomer.GetHashCode());

            Console.ReadLine();
        }
    }
}
