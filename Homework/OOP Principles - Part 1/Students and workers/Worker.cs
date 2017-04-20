using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public class Worker:Human, IWorker
    {
        private int weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay): base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("The salary must be positive number");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("The hours per daay must be a positive number");
                }
                this.workHoursPerDay = value;
            }
        }

        public int MoneyPerHour()
        {
            var workHoursPerWeek = this.WorkHoursPerDay * 5;
            var result = this.WeekSalary / workHoursPerWeek;
            return result;
        }
       
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} - week salary: {this.WeekSalary}, work hours per day:{this.WorkHoursPerDay},money per hour: {this.MoneyPerHour()}";
        }
    }
}
