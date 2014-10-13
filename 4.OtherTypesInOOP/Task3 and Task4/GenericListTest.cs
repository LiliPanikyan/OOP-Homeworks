using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListTest
    {
        public static void Main(string[] args)
        {
            GenericList<string> myList = new GenericList<string>();
            myList.Add("Gosho");
            myList.Add("Pesho");
            myList.Add("Maria");
            myList.Add("Ivan");
            Console.WriteLine(myList);
            Console.WriteLine("At position [2] in List is: "+ myList[2]);
            Console.WriteLine("Search for Ivan: at position "+ myList.Indexof("Ivan"));
            myList.InsertAt(2, "Pavel");
            Console.WriteLine("Insert Pavel at position 2: "+ myList);
            myList.Remove(2);
            Console.WriteLine("Remove position 2: " + myList);
            Console.WriteLine("Lenght size: "+myList.Count);
            Console.WriteLine("Min value: {0}", myList.MinValue());
            Console.WriteLine("Max value: {0}",myList.MaxValue());
            Console.WriteLine();

            var allAttributes = myList.GetType().GetCustomAttributes(typeof(VersionAttribute), false).ToArray().FirstOrDefault();
            if (allAttributes != null)
            {
                VersionAttribute vt = allAttributes as VersionAttribute;
                Console.WriteLine("Version: " + vt.ToString());
            }

            
            Console.ReadLine();
        }
    }
}
