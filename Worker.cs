using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Human
{
    class Worker:Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay{get; set;}
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double MonyPerHours()
        {
            return WeekSalary / WorkHoursPerDay*5;
        }
    }
}
