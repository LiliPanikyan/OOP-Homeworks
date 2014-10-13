using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    class ValidateData
    {
        public static void checkStringsValue(string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name is requred!", name);
            }
        }
        public static void checkNumbersValue(object value, string name)
        {
            if((decimal)value <= 0)
            {
                throw new ArgumentOutOfRangeException("Price can't be negative or zero!", name);
            }
        }
    }
}
