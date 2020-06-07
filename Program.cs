using System;
using System.Collections.Generic;
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
            Console.WriteLine(GetFirstName());
        }
        private static string GetFirstName()
        {
            while (true)
            {
                WriteLine("Please enter first name");

                string firstName = ReadLine();

                if (firstName == null || firstName.Length == 0 || IsAllWhiteSpace(firstName))
                {
                    WriteLine("ERROR: Invalid first name");
                }
                else
                {
                    return firstName;
                }
            }
            
         }

          private static bool IsAllWhiteSpace(string s)
        {
            if (s.Replace(" ", "").Length == 0) // doesn't take into accounts tabs
            {
                return true;
            }

            return false;
        }
    }
}