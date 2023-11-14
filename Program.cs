using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagementSystem
{
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void AddEmployee()
        {
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Designation:");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());

            int id = employees.Count + 1; // Simple way to generate a unique ID

            employees.Add(new Employee { Id = id, Name = name, Designation = designation, Salary = salary });
            Console.WriteLine("Employee added successfully.");
        }

        static void ViewEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Designation: {employee.Designation}, Salary: {employee.Salary}");
            }
        }

        static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee ID to Update:");
            int id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                Console.WriteLine("Enter New Name:");
                employee.Name = Console.ReadLine();

                Console.WriteLine("Enter New Designation:");
                employee.Designation = Console.ReadLine();

                Console.WriteLine("Enter New Salary:");
                employee.Salary = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Employee updated successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }

        static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID to Delete:");
            int id = int.Parse(Console.ReadLine());

            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employees.Remove(employee);
                Console.WriteLine("Employee deleted successfully.");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. View Employees");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        ViewEmployees();
                        break;
                    case 3:
                        UpdateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}