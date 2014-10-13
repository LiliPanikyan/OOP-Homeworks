using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompanyHierarchyProject
{
    public class ValidationMethods
    {
        public static string ValidateName(string value)
        {
            if (string.IsNullOrEmpty(value) || (!Regex.Match(value, "^[a-zA-Z]").Success) || value.Length < 3)
            {
                throw new ArgumentNullException("Name is mising or is incorrectly entered!");
            }
            return value;
        }

        public static int ValidateIdNumber(int value)
        {
            string input = value.ToString();
            if (string.IsNullOrEmpty(input) || (!Regex.Match(input, "^[0-9]").Success) || input.Length < 8)
            {
                throw new ArgumentNullException("ID number is mising or is incorrectly entered! Please enter 8 digit number");
            }
            return value;
        }

        public static string CheckForEmptyString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Please enter product name!");
            }
            return value;
        }

        public static string ValidateDate(string date)
        {
            DateTime dateTime;
            if (DateTime.TryParse(date, out dateTime))
            {
                return dateTime.ToShortDateString();
            }
            else
            {
                throw new ArgumentException("Invalid data! Please enter string in format dd-mm-YYYY.");
            }
        }

        public static decimal ValidateMoneyValue(decimal value)
        {
            if (value < 0 || value.ToString() == "")
            {
                throw new ArgumentNullException("Negative or missing input!");
            }
            return value;
        }
    }
}
