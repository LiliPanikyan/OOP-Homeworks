using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace School
{
    public class Student : Person
    {
        private int studentClassNumber;

        public Student(string firstName, string lastName, int studentClassNumber, string details = null)
            : base(firstName, lastName, details)
        {
            this.StudentClassNumber = studentClassNumber;
        }

        public int StudentClassNumber
        {
            get
            {
                return this.studentClassNumber;
            }
            set
            {
                if (value < 0 || value > 40)
                {
                    throw new ArgumentOutOfRangeException("Invalid number! Number must be [0....40]");
                }
                this.studentClassNumber = value;
            }
        }
    }
}
