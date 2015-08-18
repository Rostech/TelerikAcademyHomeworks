

namespace StudentsAndWorkers.Models
{

    using System;

    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string fname, string lname, double weekSalary, double workHoursPerDay)
            :base(fname, lname)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }


        public double WeekSalary
        { 
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException(string.Format("The worker cannot work for {0}", value));
                this.weekSalary = value;
            }
        }
        public double WorkHoursPerDay 
        { 
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value > 24)
                    throw new ArgumentException("One day has only 24 hours!");
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double daySalary = this.WeekSalary / 5; // because the worker works 5 days in the week
            double moneyPerHour = this.WorkHoursPerDay / daySalary;
            return moneyPerHour;
        }
    }
}
