using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentsWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public double PeymantPerHour
        {
            get
            {
                return this.MoneyPerHour();
            }
        }

        private double MoneyPerHour()
        {
            double result = this.WeekSalary / (this.WorkHoursPerDay * 5);
            return result;
        }
    }
}