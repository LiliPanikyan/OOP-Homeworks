using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string customerID;
        private string customerPermanentAddress;
        private string customerMobilePhone;
        private string customerEmail;
        private IList<Payment> customerPayments;
        private CustomerType typeCustomer;

        public Customer(string firstName, string middleName, string lastName, string customerID,
            string customerPermanentAddress, string customerMobilePhone, string customerEmail,
            IList<Payment> customerPayments, CustomerType typeCustomer)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.CustomerID = customerID;
            this.CustomerPermanentAddress = customerPermanentAddress;
            this.CustomerMobilePhone = customerMobilePhone;
            this.CustomerEmail = customerEmail;
            this.CustomerPayments = customerPayments;
            this.TypeCustomer = typeCustomer;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string CustomerID { get; set; }

        public string CustomerPermanentAddress { get; set; }

        public string CustomerMobilePhone { get; set; }

        public string CustomerEmail { get; set; }

        public IList<Payment> CustomerPayments { get; set; }

        public CustomerType TypeCustomer { get; set; }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;
            if (customer == null)
            {
                return false;
            }
            if ((!(Equals(this.FirstName, customer.FirstName)) ||
                (!(Equals(this.MiddleName, customer.MiddleName)) ||
                (!(Equals(this.LastName, customer.LastName)) ||
                (!(Equals(this.CustomerID, customer.CustomerID) ||
                (!(Equals(this.CustomerPermanentAddress, customer.CustomerPermanentAddress)) ||
                (!(Equals(this.CustomerMobilePhone, customer.CustomerMobilePhone)) ||
                (!(Equals(this.CustomerEmail, customer.CustomerEmail)) ||
                (this.CustomerPayments.Count != customer.CustomerPayments.Count)) ||
                (!(Equals(this.TypeCustomer, customer.TypeCustomer)))))))))))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override int GetHashCode()
        {
            return
                this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.CustomerID.GetHashCode() ^
                this.CustomerPermanentAddress.GetHashCode() ^
                this.CustomerMobilePhone.GetHashCode() ^
                this.CustomerEmail.GetHashCode() ^
                this.CustomerPayments.GetHashCode() ^
                this.TypeCustomer.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder customerData = new StringBuilder();
            customerData.AppendFormat(
                "Customer: {0} {1} {2}\n",
                this.FirstName,
                this.MiddleName,
                this.LastName);
            customerData.AppendFormat("ID: {0}\n", this.CustomerID);
            customerData.AppendFormat("Permanent address: {0}\n", this.CustomerPermanentAddress);
            customerData.AppendFormat("Mobile phine: {0}\n", this.CustomerMobilePhone);
            customerData.AppendFormat("Email: {0}\n", this.CustomerEmail);

            string paymentsInStringFormat = "";
            foreach (var payment in this.CustomerPayments)
            {
                paymentsInStringFormat += payment.ProductName + " " + payment.ProductPrice + "\n";
            }

            customerData.AppendFormat("Payments:\n{0}", paymentsInStringFormat);
            customerData.AppendFormat("Customer type: {0}\n", this.TypeCustomer);

            return customerData.ToString();
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !Equals(firstCustomer, secondCustomer);
        }

        public object Clone()
        {
            List<Payment> clonedPayments = new List<Payment>();
            foreach (var item in this.CustomerPayments)
            {
                clonedPayments.Add(item);
            }

            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.CustomerID,
                this.CustomerPermanentAddress,
                this.CustomerMobilePhone,
                this.CustomerEmail,
                clonedPayments,
                this.TypeCustomer);
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            return this.CustomerID.CompareTo(other.CustomerID);
        }
    }
}
