using System;
using System.Collections.Generic;

namespace CompanyHierarchyProject
{
    class CompanyHierarchyProject
    {
        static void Main()
        {
            List<Employee> stivRobertsEmployees = new List<Employee>()
            {
                new Employee("Mery", "Popins", 11312312, 3236.32m, Department.Accounting),
                new Employee("John", "Barns", 22312312, 3936.88m, Department.Marketing),
                new Employee("Bary", "Smith", 33312312, 3736.88m, Department.Production),
                new Employee("Janet", "Smith", 44312312, 3536.88m, Department.Sales)

            };

            List<Employee> emyMarksEmployees = new List<Employee>()
            {
                new Employee("Mery", "Barns", 33312312, 3236.32m, Department.Accounting),
                new Employee("John", "Smith", 22442312, 3936.88m, Department.Marketing),
                new Employee("Bary", "Willfar", 33355312, 3736.88m, Department.Production),
                new Employee("Janet", "Pery", 44312662, 3536.88m, Department.Sales)

            };

            List<Manager> managers = new List<Manager>()
            {
                new Manager("Stiv", "Roberts", 55123454, 5643.22m, Department.Accounting, stivRobertsEmployees),
                new Manager("Emy", "Marks", 96325814, 5456.32m, Department.Marketing, emyMarksEmployees)
            };

            foreach (var manager in managers)
            {
                Console.WriteLine("Department: " + manager.Department + "\nManager " + manager.FirstName + " " + manager.LastName + "\nSet of Employees: ");
                foreach (var employee in manager.SetOfEmployees)
                {
                    Console.WriteLine(employee.IdNumber + " " + employee.FirstName + " " + employee.LastName);
                }
                Console.WriteLine();
            }

            List<Sales> anaSales = new List<Sales>()
            {
                new Sales("Samsung TV 2020", "20-09-2014", 999.90m),
                new Sales("APPLE IPAD MD785HC/A", "10-09-2014", 799.90m),
                new Sales("Phablet SONY XPERIA Z ULTRA", "20-09-2014", 999.90m)

            };

            List<Sales> barySales = new List<Sales>()
            {
                new Sales("Samsung TV 2020", "20-09-2014", 999.90m),
                new Sales("APPLE IPAD MD785HC/A", "20-09-2014", 799.90m),
                new Sales("Phablet SONY XPERIA Z ULTRA", "20-09-2014", 999.90m)

            };

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>()
            {
                new SalesEmployee("Ana", "Burns", 36536536, 2365.32m, Department.Sales, anaSales),
                new SalesEmployee("Bary", "Smith", 36666536, 2365.32m, Department.Sales, barySales)
            };

            decimal sumSales = 0m;
            foreach (var saler in salesEmployees)
            {
                Console.WriteLine("Department: " + saler.Department + "\nSaler " + saler.FirstName + " " + saler.LastName + "\nSales: ");
                foreach (var sale in saler.SetOfSales)
                {
                    sumSales += sale.Price;
                    Console.WriteLine(sale.Date + " " + sale.Price);
                }
                Console.WriteLine("Total amount: " + sumSales);

                sumSales = 0m;
                Console.WriteLine();
            }

            List<Project> jorgeProjects = new List<Project>()
            {
                new Project("SnakeGame", "10-09-2014", "Zero tests successful" ,State.Open),
                new Project("SharkGame", "15-09-2014", "Zero tests successful" ,State.Open),
                new Project("BeeGame", "01-09-2014", "All tests successful" ,State.Close),

            };

            List<Project> willProjects = new List<Project>()
            {
                new Project("BankAccount", "01-09-2014", "Zero tests successful" ,State.Open),
                new Project("BeeGame", "01-09-2014", "All tests successful" ,State.Close),

            };

            List<Developer> developers = new List<Developer>()
            {
                new Developer("Jorge", "Molty", 98765421, 45698.36m, Department.Production, jorgeProjects),
                new Developer("Will", "Bush", 88765421, 45698.36m, Department.Production, willProjects)
            };

            foreach (var item in developers)
            {
                Console.WriteLine("Department:{0}\n{1} {2} ID: {3}\n", item.Department, item.FirstName, item.LastName, item.IdNumber);
            }
            Console.ReadLine();



        }
    }
}
