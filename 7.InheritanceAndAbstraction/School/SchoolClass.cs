using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass
    {
        private string uniqueTextIdentifier;
        private IList<Teachers> setOfTeachers;
        private string details;

        public SchoolClass(string uniqueTextIdentifier, IList<Teachers> setOfTeachers, string details = null)
        {
            this.UniqueTextIdentifier = uniqueTextIdentifier;
            this.SetOfTeachers = setOfTeachers;
            this.Details = details;
        }

        public IList<Teachers> SetOfTeachers { get; set; }

        public string UniqueTextIdentifier { get; set; }

        public string Details { get; set; }
    }
}
