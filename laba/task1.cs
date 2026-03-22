using System;

namespace laba_3
{
    public class Employee
    {
        private readonly int id;
        private string name;
        private double salary;

        private static int counter = 0;
    }
    public Employee(string name, double salary)
    {
        counter++;
        this.id = counter;
        this.name = name;
        this.salary = salary;
    }
    
    public Employee(string name) : this(name, 0) {}
}

