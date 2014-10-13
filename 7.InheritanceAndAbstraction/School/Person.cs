using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string details;

        public Person(string firstName, string lastName, string details = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Details = details;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                validateName(value);
                this.firstName = value;
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
                validateName(value);
                this.lastName = value;
            }
        }

        public string Details { get; set; }

        private static string validateName(string value)
        {
            if (string.IsNullOrEmpty(value) || (!Regex.Match(value, "^[a-zA-Z]").Success) || value.Length < 3)
            {
                throw new ArgumentNullException("Name is mising or is incorrectly entered!");
            }
            return value;
        }
    }
}
