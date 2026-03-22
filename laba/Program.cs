using System;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Arina", 150000000);
            Employee emp2 = new Employee("Diana");

            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());

            Console.WriteLine($"\nArina's salary now: {emp2.Salary} hrn");
            emp1.raiseSalary(200);
            Console.WriteLine($"New salary for Arina: {emp1.Salary} hrn");
            
            Console.WriteLine($"Arina's anual income: {emp1.Income()} hrn");

            Console.WriteLine($"\ncreated: {Employee.Total()}");

            Console.ReadKey();
        }
    }
}
