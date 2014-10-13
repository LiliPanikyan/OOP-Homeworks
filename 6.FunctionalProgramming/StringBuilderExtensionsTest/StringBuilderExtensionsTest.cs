using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtensionsTest
{
   class StringBuilderExtensionsTest
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder("Hello I'm some text");
            StringBuilder rezult = text.SubstringMethod(6, 9);
            Console.WriteLine(rezult);
            
            Console.WriteLine(text.RemoveTextMethod("Hello"));

            StringBuilder strText = new StringBuilder();
            strText.AppendAll(new List<string>() { "Hello", ", ", "I'm ", "some ", "text" })
                   .AppendAll(new List<string>() { "\nMe ", "too. ", " Smile.." });
            Console.WriteLine(strText);

            Console.ReadLine();
        }

       



    }
}
