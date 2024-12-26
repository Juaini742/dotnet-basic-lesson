using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _7_language_integrated_query.Emp;

namespace _7_language_integrated_query
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Department = "HR",
                    Salary = 5000,
                },
                new Employee
                {
                    Id = 2,
                    Name = "Bob",
                    Department = "IT",
                    Salary = 7000,
                },
                new Employee
                {
                    Id = 3,
                    Name = "Charlie",
                    Department = "Finance",
                    Salary = 6500,
                },
                new Employee
                {
                    Id = 4,
                    Name = "Diana",
                    Department = "IT",
                    Salary = 8000,
                },
                new Employee
                {
                    Id = 5,
                    Name = "Eve",
                    Department = "HR",
                    Salary = 5500,
                },
            };

            var iTEmployee =
                from employee in employees
                where employee.Department == "IT"
                select employee;

            Console.WriteLine("LIST OF EMPLOYEE IN IT DEPARTMENT");
            foreach (var emp in iTEmployee)
            {
                Console.WriteLine(
                    $"Id: {emp.Id} - Name: {emp.Name} - Department: {emp.Department} - Salary: {emp.Salary}"
                );
            }

            System.Console.WriteLine("");

            var sortedEmployee = employees.OrderBy(employee => employee.Salary);
            System.Console.WriteLine("LIST OF EMPLOYEE IN ORDER OF SALARY");
            foreach (var emp in sortedEmployee)
            {
                System.Console.WriteLine(
                    $"Id: {emp.Id} - Name: {emp.Name} - Department: {emp.Department} - Salary: {emp.Salary}"
                );
            }

            System.Console.WriteLine("");

            double? averageEmployeeSalary = (double?)employees.Average(emp => emp.Salary);
            Console.WriteLine($"Average Employee Salary: {averageEmployeeSalary}");

            Console.WriteLine("");

            var highestPaidEmployee = employees
                .OrderByDescending(emp => emp.Salary)
                .FirstOrDefault();

            if (highestPaidEmployee != null)
            {
                System.Console.WriteLine("THE HIGHEST OF EMPLOYEES SALARY");
                Console.WriteLine(
                    $"Id: {highestPaidEmployee.Id}, Name: {highestPaidEmployee.Name}, Salary: {highestPaidEmployee.Salary}"
                );
            }
        }
    }
}
