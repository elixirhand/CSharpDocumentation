using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using static System.Console;

namespace Employee
{
    class Program
    {
        class Employee
        {
            public string FirstName { get; set; }
            public char EmployeeCode { get; set; }
            public int ProductivityRating { get; set; }
            public List<string> Skills { get; } = new List<string>();
            public string Bio { get; set; }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Hello World!");
            employee.FirstName = GetFirstName();
            employee.EmployeeCode = GetEmployeeCode();
            employee.ProductivityRating = GetProductivity();
            DisplayEmployee(employee);

            WriteLine();
            WriteLine("Press enter to exit.");
            ReadLine();
        }


        private static string GetFirstName()
        {
            while (true)
            {
                WriteLine("Please enter first name");

                string firstName = ReadLine();

                if (string.IsNullOrWhiteSpace(firstName))
                {
                    WriteLine("ERROR: Invalid first name");
                }
                else
                {
                    return firstName;
                }
            }
        }

        private static char GetEmployeeCode()
        {
            while (true)
            {
                WriteLine("Please enter employee code");

                char employeeCode = ReadLine().First(); // Additional validation omitted
                UnicodeCategory ucCategory = char.GetUnicodeCategory(employeeCode);

                bool isValidUnicode = ucCategory != UnicodeCategory.OtherNotAssigned;

                if (!isValidUnicode)
                {
                    WriteLine();
                    WriteLine("Error: Invalid employee code (Invalid character)");
                }
                else
                {
                    return employeeCode;
                }
                
            }
        }

        private static int GetProductivity()
        {
            WriteLine("Please enter productivity rating (-100 to 100) enter 0 for new employees");

            int rating = int.Parse(ReadLine()); // Additional validation omitted

            return rating;
        }

        private static void DisplayEmployee(Employee employee)
        {
            WriteLine("Employee Details");
            WriteLine("----------------");
            WriteLine();

            
            // Instead
            string line = string.Format("First Name: {0} Employee Code: {1}",
                employee.FirstName, employee.EmployeeCode);
            WriteLine(line);
        }

       
    }
}