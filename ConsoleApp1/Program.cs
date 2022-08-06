using System;

namespace ConsoleApp1
{
    public class Employee4
    {
        public string id;
        public string name;

        public Employee4()
        {
        }

        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public int employeeCounter;

        public int AddEmployee()
        {
            return ++employeeCounter;
        }
    }

    public class MainClass : Employee4
    {
        static void Main()
        {
            Console.Write("Enter the employee's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the employee's ID: ");
            string id = Console.ReadLine();

            // Create and configure the employee object.
            Employee4 e = new Employee4(name, id);
            Console.Write("Enter the current number of employees: ");
            string n = Console.ReadLine();
            e.employeeCounter = Int32.Parse(n);
            e.AddEmployee();

            // Display the new information.
            Console.WriteLine($"Name: {e.name}");
            Console.WriteLine($"ID:   {e.id}");
            Console.WriteLine($"New Number of Employees: {e.employeeCounter}");
        }
    }
}
