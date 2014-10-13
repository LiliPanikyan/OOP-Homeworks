using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllStudentsTasks
{

  
    public class Student
    {

        private string firstName;
        private string lastName;
        private string facultyNumber;
        private int age;
        private string phone;
        private string email;
        private List<double> marks;
        private int groupNumber;
        private string groupName;

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

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number is mising!");
                }
                this.facultyNumber = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Invalid age!");
                }
                this.age = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || (!Regex.Match(value, "^[0-9+]*$").Success))
                {
                    throw new ArgumentNullException("Phone is requered or is Invalid number!");
                }                
                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (IsValidEmail(value) == true)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Invalid email address!");

                }
            }
        }

        public List<double> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }
       
        public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, List<double> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;

        }

        public override string ToString()
        {
            string marksList = String.Join(", ", this.Marks);
            string result =
                String.Format("Name: {0} {1},\nAge: {2} \nFactualy number: {3}, \nPhone: {4}, \nEmail: {5}, \nMarks: {6},\nGroup number: {7},\nGroup name: {8}\n ",
                this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email,
                marksList, this.GroupNumber, this.GroupName);

            return result;
        }

        private static void validateName(string value)
        {
            if (string.IsNullOrEmpty(value) || (!Regex.Match(value, "^[a-zA-Z]").Success))
            {
                throw new ArgumentNullException("Name is mising or is incorrectly entered!");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
