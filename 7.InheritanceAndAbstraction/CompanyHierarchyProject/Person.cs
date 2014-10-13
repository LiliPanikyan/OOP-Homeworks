using CompanyHierarchyProject.Interfaces;
using System;
using System.Text.RegularExpressions;

namespace CompanyHierarchyProject
{
    public class Person : IPerson
    {
        protected int idNumber;
        protected string firstName;
        protected string lastName;

        public Person(string firstName, string lastName, int idNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IdNumber = idNumber;
        }

        public int IdNumber
        {
            get
            {
                return this.idNumber;
            }
            set
            {
                this.idNumber = ValidationMethods.ValidateIdNumber(value);
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {                
                this.firstName = ValidationMethods.ValidateName(value);
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = ValidationMethods.ValidateName(value);

            }
        }

        public override string ToString()
        {
            string result = String.Format("{0} {1} ID number: ", this.FirstName, this.LastName, this.IdNumber);
            return result;
        }

        

        
    }
}
