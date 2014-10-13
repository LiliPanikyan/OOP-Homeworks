using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HumanStudentsWorker
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
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

        private static void validateName(string value)
        {
            if (string.IsNullOrEmpty(value) || (!Regex.Match(value, "^[a-zA-Z]").Success) || value.Length < 3)
            {
                throw new ArgumentNullException("Name is mising or is incorrectly entered!");
            }
        }
    }
}
