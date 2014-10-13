using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculatorTest
{
    public class InterestCalculator
    {
        static void Main()
        {
            Func<decimal, double, int, decimal> myFuncSimple = new Func<decimal, double, int, decimal>(GetSimpleInterest);
            Console.WriteLine("{0:0.0000}",myFuncSimple(500m,5.6,10));

            Func<decimal, double, int, decimal> myFuncCompound = new Func<decimal, double, int, decimal>(GetCompoundInterest);
            Console.WriteLine("{0:0.0000}", myFuncSimple(2500m, 7.2, 15));
            Console.ReadLine();

        }
        static decimal GetSimpleInterest(decimal money, double interest, int years)
        {
            if (interest < 0 || years < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                decimal rezult = money * (decimal)(1 + (interest * years / 100));
                return rezult;
            }

        }
        static decimal GetCompoundInterest(decimal money, double interest, int years)
        {
            if (interest < 0 || years < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                byte n=12;
                decimal rezult = money * (decimal)Math.Pow(1 + (interest / n / 100), years * n);
                return rezult;
            }

        }

    }
}
