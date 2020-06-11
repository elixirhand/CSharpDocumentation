using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
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
            public BigInteger Salary { get; set; }
            public string Bio { get; set; }
            public int Id { get; set; }
            public List<int> WorkDays { get; set; }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("Hello World!");
            //employee.FirstName = GetFirstName();
            //employee.EmployeeCode = GetEmployeeCode();
            //employee.ProductivityRating = GetProductivity();
            //GetSkillsFor(employee);
            WriteLine();
            //Console.WriteLine($"DOB: {GetDateOfBirth()}");
            //(employee);
            //employee.Salary = GetSalary();
            //employee.Id = GenerateRandomId();
            //employee.WorkDays = GenerateDefaultWorkDays();
            DisplayEmployeeSkills(employee);


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

            string input = ReadLine();
            
            int rating = int.Parse(input, NumberStyles.AllowTrailingSign); // Additional validation omitted

            return rating;
        }
        
        private static void GetSkillsFor(Employee employee)
        {
            // Simulate getting skills from user-input
            employee.Skills.Add("C#");
            employee.Skills.Add("HTML");
            employee.Skills.Add("SQL");
            employee.Skills.Add("JSON");
            
        }

        private static DateTime GetDateOfBirth()
        {
            WriteLine("Please enter your date of birth");
            string input = ReadLine();

            //DateTime dateOfBirth = DateTime.Parse(input);
            DateTime dateOfBirth = DateTime.ParseExact(input, "MM/dd/yyyy", null);

            //Adding multiple DateFormat
            DateTime dateTime1 = DateTime.Parse("01/12/2000");
            DateTime dateTime2 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeUniversal);
            DateTime dateTime3 = DateTime.Parse("01/12/2000", null, DateTimeStyles.AssumeLocal);
            DateTime dateTime4 = DateTime.Parse("13:30:00");
            DateTime dateTime5 = DateTime.Parse("13:30:00", null, DateTimeStyles.NoCurrentDateDefault);

            return dateOfBirth;
        }
        
        //This method will populate the employees salary
        private static BigInteger GetSalary()
        {
            WriteLine("Please enter salary");

            string input = ReadLine();

            BigInteger value = BigInteger.Parse(input);

            return value;
        }

        /// <summary>
        /// Instead using Cryptographically Secure Random numbers 
        /// Because this class (RNGCryptoServiceProvider : RandomNumberGenerator : IDisposable) 
        /// implements IDisposable that is why wrpped into using
        /// </summary>
        /// <returns></returns>
        
        private static int GenerateRandomId()
        {
            using RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider(); 
            byte[] randomBytesNumber = new byte[4];

            rnd.GetBytes(randomBytesNumber);

            int result = BitConverter.ToInt32(randomBytesNumber, 0);

            return result;
        }

        private static List<int> GenerateDefaultWorkDays()
        {
            //List<int> workDays = new List<int>();

            //for (int i = 1; i < 6; i++)
            //{
            //    workDays.Add(i);
            //}

            //return workDays;

            return Enumerable.Range(1, 5).Select(x => x * 2).ToList(); 
        }

        private static void DisplayEmployeeSkills(Employee employee)
        {
            WriteLine($"Work Days: {string.Join(",", employee.WorkDays = GenerateDefaultWorkDays())}");
        }

    }
}