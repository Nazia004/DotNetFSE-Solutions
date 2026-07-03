using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService service = new EmployeeService(10);

            service.AddEmployee(new Employee(101, "Nazia", "Software Engineer", 60000));
            service.AddEmployee(new Employee(102, "Rahul", "QA Engineer", 50000));
            service.AddEmployee(new Employee(103, "Anjali", "Project Manager", 85000));

            service.DisplayEmployees();

            Console.WriteLine("\nSearching Employee ID 102:");

            Employee? employee = service.SearchEmployee(102);

            if (employee != null)
                Console.WriteLine(employee);
            else
                Console.WriteLine("Employee not found.");

            Console.WriteLine();

            service.DeleteEmployee(102);

            service.DisplayEmployees();
        }
    }
}
