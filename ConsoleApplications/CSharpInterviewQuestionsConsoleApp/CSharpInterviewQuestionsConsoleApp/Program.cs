using CSharpInterviewQuestionsConsoleApp.Abstract_Class_Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Storing different data types in 1. Object array 2. ArrayList
            StoringDifferentDataTypesInArray typesInArray = new StoringDifferentDataTypesInArray();
            typesInArray.CreateObjectArray();
            typesInArray.CreateArrayList();

            Console.WriteLine();

            // Jagged Array
            JaggedArray jagged = new JaggedArray();
            jagged.CreateJaggedArray();

            Console.WriteLine();

            // If we try to create an instance of Abstract class, we get compilation error
            // BaseEmployee baseEmployee = new BaseEmployee();

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mark",
                LastName = "Doe",
                YearlySalary = 600000
            };

            Console.WriteLine(fullTimeEmployee.GetFullName()); 
            Console.WriteLine("Monthly Salary: " + fullTimeEmployee.GetMonthlySalary());

            Console.WriteLine("----------------------");

            ContractEmployee contractEmployee = new ContractEmployee()
            {
                ID = 102,
                FirstName = "John",
                LastName = "Doe",
                HourlyPay = 125,
                TotalHours = 240
            };

            Console.WriteLine(contractEmployee.GetFullName());
            Console.WriteLine("Monthly Salary: " + contractEmployee.GetMonthlySalary());

            Console.WriteLine("----------------------");
        }
    }
}
