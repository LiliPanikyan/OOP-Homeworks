using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensionsTest
{
    public static class Extensions
    {
        public static StringBuilder SubstringMethod(this StringBuilder text, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            string str = text.ToString();
            if (startIndex > str.Length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = startIndex; i < length; i++)
                {
                    result.Append(str[i]);

                }
            }
            return result;
        }

        public static StringBuilder RemoveTextMethod(this StringBuilder text, string textToReplace)
        {
            text.Replace(textToReplace, "");
            return text;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder text, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                text.Append(item);
            }
            return text;
        }
    }
}
