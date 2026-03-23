using System;

namespace laba_3
{
    public class Employee
    {
        //private readonly int id;
        private int id;
        private string name = "";
        private double salary;

        private static int counter = 0;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee() {} //для десеріалізації

        public Employee(string name, double salary)
        {
            counter++;
            this.id = counter;
            this.name = name;
            this.salary = salary;
        }

        public Employee(string name) : this(name, 0) {}

        //public double Salary
        //{
        //    get { return this.salary; }
        //}

        public void raiseSalary(double percentage)
        {
            if (percentage > 0)
            {
                this.salary += this.salary * (percentage / 100);
            }
        }

        public double Income()
        {
            return this.salary * 12;
        }

        public static int Total()
        {
            return counter;
        }

        public override string ToString()
        {
            return $"ID: {this.id} | Employee: {this.name} | Salary: {this.salary} hrn";
        }
    }
}

