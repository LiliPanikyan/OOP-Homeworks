using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanStudentsWorker
{
    class HumanStudentsWorker
    {
        static void Main()
        {
            var students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", "aaaaaaaaaa"));
            students.Add(new Student("Pavel", "Ivanov", "bbbbbbbbbb"));
            students.Add(new Student("Pavlina", "Ivanova", "cccccccccc"));
            students.Add(new Student("Maria", "Ivanova", "dddddddddd"));
            students.Add(new Student("Irina", "Petrova", "aaaaaaaabb"));
            students.Add(new Student("Mitko", "Petrov", "bbaaaaaabb"));
            students.Add(new Student("Mitko", "Peshev", "1111111111"));
            students.Add(new Student("Pesho", "Peshev", "2222222222"));
            students.Add(new Student("Gorg", "Lory", "1111aaaaaa"));
            students.Add(new Student("Mery", "Popins", "111bbbbbbb"));

            students = students.OrderBy(x => x.FaultyNumber).ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.FaultyNumber);
            }

            Console.WriteLine();
            var workers = new List<Worker>();
            workers.Add(new Worker("Yavor", "Ivanov", 260.55, 8));
            workers.Add(new Worker("Ivo", "Ivanov", 320.65, 8));
            workers.Add(new Worker("Poli", "Ivanova", 220.35, 6));
            workers.Add(new Worker("Marina", "Ivanova", 120.55, 4));
            workers.Add(new Worker("Penka", "Petrova", 140.35, 4));
            workers.Add(new Worker("Doni", "Petrov", 355.65, 8));
            workers.Add(new Worker("Todor", "Peshev", 345.65, 8));
            workers.Add(new Worker("Vasko", "Peshev", 345.86, 8));
            workers.Add(new Worker("Mery", "Lory", 350.50, 8));
            workers.Add(new Worker("Joly", "Popins", 360.80, 8));

            workers = workers.OrderByDescending(x => x.PeymantPerHour).ToList();

            foreach (var item in workers)
            {
                Console.WriteLine(item.PeymantPerHour);
            }

            Console.WriteLine();
            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            var sortedPeople = people
                .OrderBy(person => person.FirstName)
                .ThenBy(person => person.LastName)
                .Select(person => person);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
            Console.ReadLine();
        }
    }
}
