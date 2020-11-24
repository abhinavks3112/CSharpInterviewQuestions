using CSharpInterviewQuestionsConsoleApp.Abstract_Class_Concept;
using CSharpInterviewQuestionsConsoleApp.InputData;
using CSharpInterviewQuestionsConsoleApp.Recursion_Concept;
using CSharpInterviewQuestionsConsoleApp.Reverse_String_Concept;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Input input = new Input();
            /*
            // Comment out when you want to test the output of any concept
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
            
            // Factorial
            //Console.WriteLine("Enter number for calculating its factorial");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //Factorial factorial = new Factorial();
            //Console.WriteLine("\nFactorial of " + number + " is: " + factorial.Calculate(number)); 
            //Console.WriteLine();
            //Console.WriteLine("\nFactorial of " + number + " by recursion is: " + factorial.CalculateByRecursion(number));

            Console.WriteLine();

            // Get All Files in Folder and SubFolder by Recursion
            var enviroment = System.Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;
            FindAllFilesInFolderAndSubFolder findAllFiles = new FindAllFilesInFolderAndSubFolder();
            findAllFiles.GetAllFilesInDirectories(projectDirectory + "/Recursion_Concept/Sample");
            Console.WriteLine();

            //Reverse every word in a given string
            ReverseEveryWordInString reverse = new ReverseEveryWordInString();
            reverse.ReverseEveryWordWithBuiltInMethod();
            reverse.ReverseEveryWordWithoutBuiltInMethod();            

            Two_Pointer_Problem.TwoSum twoSum = new Two_Pointer_Problem.TwoSum();
            Dictionary<int, int> dictionaries = twoSum.FindIndicesAndElements(input.unSortedFixedArray, input.unSortedFixedArrayTwoNumberSum);

            Two_Pointer_Problem.TwoSumSortedArray sortedArray = new Two_Pointer_Problem.TwoSumSortedArray();
            Dictionary<int, int> dictionaries1 = twoSum.FindIndicesAndElements(input.sortedFixedArray, input.sortedFixedArrayTwoNumberSum);
            */

            Find_All_Substrings.FindAllSubstringsWithGivenCharacters findAll = new Find_All_Substrings.FindAllSubstringsWithGivenCharacters();
            findAll.FindingThroughBruteSearch(input.randomString, input.randomSubString);
        }
    }
}
