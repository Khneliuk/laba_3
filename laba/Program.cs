namespace laba_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Arina", 50000000);
            Console.WriteLine(emp);

            Console.WriteLine($"created {Employee.Total()}");
        }
    }
}

