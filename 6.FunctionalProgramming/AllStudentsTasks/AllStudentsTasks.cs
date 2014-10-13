using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllStudentsTasks
{
    class AllStudentsTasks
    {
        static void Main(string[] args)
        {
            //Task3-------------------------------//
            Student stud1 = new Student("Ivan", "Petrov", 26, "1000114", "+3598898999999", "ivan.petrov@abv.bg", new List<double>() { 2, 4.65, 2 }, 1, "OOP");
            Student stud2 = new Student("Irina", "Petrova", 22, "2000214", "+359888888888", "irina.petrova@yahoo.com", new List<double>() { 4.545, 5.65, 6 }, 2, "OOP");
            Student stud3 = new Student("Pesho", "Ivanov", 21, "2000113", "+35929733333", "pesho.ivanov@gmail.bg", new List<double>() { 4.545, 5.65, 6 }, 2, "PHP");
            Student stud4 = new Student("Ivan", "Ivanov", 36, "100012", "028701010", "ivan.ivanov@abv.bg", new List<double>() { 5.545, 6, 6 }, 1, "PHP");

            List<Student> studentsList = new List<Student>();
            studentsList.Add(stud1);
            studentsList.Add(stud2);
            studentsList.Add(stud3);
            studentsList.Add(stud4);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 4 order by first name group 2");

            var orderGroupTwo =
                from student in studentsList
                where student.GroupNumber == 2
                orderby student.FirstName
                select student.FirstName + " " + student.LastName + " Group :" + student.GroupNumber;

            printRezult(orderGroupTwo);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 5 order be first name before last name");

            var orderFirstBeforeLastName =
                from student in studentsList
                orderby student.FirstName, student.LastName
                select student.FirstName + " " + student.LastName;

            printRezult(orderFirstBeforeLastName);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 6 order by age [18....24]");

            var orderByAge =
                from student in studentsList
                where student.Age >= 18 && student.Age <= 24
                orderby student.Age
                select student.FirstName + " " + student.LastName + " age:" + student.Age;

            printRezult(orderByAge);


            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 7 orderBy thenBy");

            studentsList.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).ToList()
                        .ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));

            var studentsInDescendingOrder =
               from student in studentsList
               orderby student.FirstName descending, student.LastName descending
               select student;

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 8 filter by email");

            var filterEmail =
                from student in studentsList
                where student.Email.Contains("@abv.bg")
                select student.FirstName + " " + student.LastName + " email: " + student.Email;

            printRezult(filterEmail);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 9 filter by phone");

            var filterPhone =
                from student in studentsList
                where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
                select student.FirstName + " " + student.LastName + " phone: " + student.Phone;

            printRezult(filterPhone);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 10 Excellent Students");

            var excellentStudents =
                from student in studentsList
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var item in excellentStudents)
            {
                string marks = string.Join(", ", item.Marks);
                Console.WriteLine("{0}: ({1})", item.FullName, marks);
            }

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 11 Weak Students");

            var weakStudents =
                from student in studentsList
                where student.Marks.Where(s => s == 2).Count() == 2
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var item in weakStudents)
            {
                string marks = string.Join(", ", item.Marks);
                Console.WriteLine("{0}: ({1})", item.FullName, marks);
            }

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 12 Students Enrolled in 2014");

            var enrolledStudents =
                from student in studentsList
                where student.FacultyNumber.EndsWith("14")
                select student.FirstName + " " + student.LastName + " Faculty number: " + student.FacultyNumber;

            printRezult(enrolledStudents);

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 13 Students by group");

            var orderByGroupName =
                from student in studentsList
                group student by student.GroupName into g
                orderby g.Key
                select g;

            foreach (var group in orderByGroupName)
            {
                Console.WriteLine("Group name: " + group.Key);
                foreach (var value in group)
                {
                    Console.WriteLine(value.FirstName + " " + value.LastName);
                }
                Console.WriteLine();
            }

            Console.WriteLine("/-------------------------/");
            Console.WriteLine("Task 14 Students Joined To Specialties");

            var specialties = new List<StudentSpecialty>() 
            { 
            new StudentSpecialty("Web Developer", "1000114"),
            new StudentSpecialty("C# Developer", "2000214"),
            new StudentSpecialty("Web Developer", "2000113"),
            new StudentSpecialty("Java Developer", "6000214"),
            new StudentSpecialty("QA", "100012")
            };

            var studentSpecialty = from student in studentsList
                join spec in specialties
                on student.FacultyNumber equals spec.FacultyNumber
                orderby spec.SpecialityName
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    facNum = student.FacultyNumber,
                    specialty = spec.SpecialityName
                };

            foreach (var item in studentSpecialty)
            {
                Console.WriteLine("{0,-15}: {1,-10} Specialty: {2,-15}", item.FullName, item.facNum, item.specialty);
            }

            Console.ReadLine();
        }

        private static void printRezult(IEnumerable<string> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);

            }
        }
    }
}
