using System;

namespace EmployeeManagement
{
    public class EmployeeService
    {
        private Employee[] employees;
        private int count;

        public EmployeeService(int size)
        {
            employees = new Employee[size];
            count = 0;
        }

        // Add Employee
        public void AddEmployee(Employee employee)
        {
            if (count < employees.Length)
            {
                employees[count] = employee;
                count++;
                Console.WriteLine("Employee added successfully.");
            }
            else
            {
                Console.WriteLine("Employee array is full.");
            }
        }

        // Search Employee
        public Employee? SearchEmployee(int employeeId)
        {
            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == employeeId)
                    return employees[i];
            }

            return null;
        }

        // Display Employees
        public void DisplayEmployees()
        {
            Console.WriteLine("\nEmployee Records:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }

        // Delete Employee
        public void DeleteEmployee(int employeeId)
        {
            int index = -1;

            for (int i = 0; i < count; i++)
            {
                if (employees[i].EmployeeId == employeeId)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            for (int i = index; i < count - 1; i++)
            {
                employees[i] = employees[i + 1];
            }

            employees[count - 1] = null!;
            count--;

            Console.WriteLine("Employee deleted successfully.");
        }
    }
}