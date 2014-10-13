using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1- Point 3D");
            Point3D pointA = new Point3D(0.5, 1.5, 2.5);
            Point3D pointB = new Point3D(1, 2, 3);
            Console.WriteLine(Point3D.StartPoint);
            Console.WriteLine(pointA);
            Console.WriteLine(pointB);
            Console.WriteLine();

            Console.WriteLine("Task 2- Distance Calculator");
            double d = DistanceCalculator.CalculateD(pointA, pointB);
            Console.WriteLine("Distanse between {0} and {1} = {2:0.00000}",pointA,pointB,d);
            Console.ReadLine();


        }
    }
}
