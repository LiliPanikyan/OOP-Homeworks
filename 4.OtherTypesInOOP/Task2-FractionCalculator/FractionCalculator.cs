using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numerator 1:");
            long num1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter denominator 1:");
            long denom1 = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter numerator 2:");
            long num2 = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter denominator 2:");
            long denom2 = long.Parse(Console.ReadLine());

            Fraction fraction1 = new Fraction(num1, denom1);

            Fraction fraction2 = new Fraction(num2, denom2);
            
            Fraction plusRezult = fraction1 + fraction2;
            Console.WriteLine(plusRezult.Numerator);
            Console.WriteLine(plusRezult.Denominator);
            Console.WriteLine("{0} + {1}= {2}",fraction1,fraction2, plusRezult);
            Fraction minusRezult = fraction2 - fraction1;
            Console.WriteLine("{0} - {1}= {2}",fraction1,fraction2,minusRezult);
            Console.ReadLine();
        }
    }
}
