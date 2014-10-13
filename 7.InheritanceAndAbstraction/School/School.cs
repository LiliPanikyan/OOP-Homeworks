using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        static void Main()
        {
            //I don't have a class diagram, because I use the Express version of Visual Studio

            List<Student> students = new List<Student>()
            {
                new Student("Maria", "Petrova", 3, "some data"),
                new Student("ivan", "Petrov", 4),
                new Student("Teodor", "Pavlov", 5)
            };

            List<Disciplines> disciplines = new List<Disciplines>()
            {
                new Disciplines("English", students, 5),
                new Disciplines("Biology", students, 2, "only monday and friday"),
                new Disciplines("Mathematic", students, 5),
            };

            List<Teachers> teachers = new List<Teachers>()
            {
                new Teachers("Pavel", "Bogdanov", disciplines),
                new Teachers("Bob", "Lory", disciplines, "vacation")
            };

            List<SchoolClass> shoolClass = new List<SchoolClass>()
            {
                new SchoolClass("Five A", teachers),
                new SchoolClass("Five B", teachers, "new student member next week")
            };


            foreach (var item in shoolClass)
            {
                Console.WriteLine("Class: " + item.UniqueTextIdentifier);
                Console.WriteLine("Students: ");
                foreach (var person in students)
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName);
                }
                Console.Write("Disciplines: [ ");
                foreach (var discipline in disciplines)
                {
                    Console.Write(discipline.DisciplinesNameID + " ");

                }
                Console.Write("]\n");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
