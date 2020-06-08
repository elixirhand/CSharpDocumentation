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
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetEmployeeCode());
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

     }
}