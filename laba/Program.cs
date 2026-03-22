using System;
using System.IO;
using System.Text.Json;
namespace laba_3
{
    class Program
    {
        static void SaveToFile(Employee emp, string fileName)
        {
            string json = JsonSerializer.Serialize(emp);
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(json);
            }
            Console.WriteLine("noted");
        }
        static Employee LoadFromFile(string fileName)
        {
            string json = "";
            using (StreamReader reader = new StreamReader(fileName))
            {
                json = reader.ReadToEnd();
            }
            Employee temp = JsonSerializer.Deserialize<Employee>(json);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                return new Employee();
            }
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Arina", 150000);
            Employee emp2 = new Employee("Diana");
            
            string path = "employee.json";

            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp2.ToString());
            
            SaveToFile(emp1, path);
            Employee restoredEmp = LoadFromFile(path);
            Console.WriteLine("\nRestored from file:");
            Console.WriteLine(restoredEmp.ToString());

            Console.WriteLine($"\nArina's salary now: {emp1.Salary} hrn");
            emp1.raiseSalary(20);
            Console.WriteLine($"New salary for Arina: {emp1.Salary} hrn");
            
            Console.WriteLine($"Arina's anual income: {emp1.Income()} hrn");

            Console.WriteLine($"\ncreated: {Employee.Total()}");

            Console.ReadKey();
        }
    }
}
