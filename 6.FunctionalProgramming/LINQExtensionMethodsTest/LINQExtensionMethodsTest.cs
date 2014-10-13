using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExtensionMethodsTest
{
    class LINQExtensionMethodsTest
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 0, 10, 20, 30, 40 };

            var result = numbers.WhereNot(x => x==20);
            printRezult(result);

            var allNumbers = numbers.Repeat(2);
            printRezult(allNumbers);

            List<string> words = new List<string>() { "tiriram", "tiriram", "tantan", "tirtam","barambum", "tantabum"};
            List<string> suffixes = new List<string>() { "am", "bum" };

            var filtredWords = words.WhereEndsWith(suffixes);

            foreach (var item in filtredWords)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }

        private static void printRezult(IEnumerable<int> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
