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
            
            Find_All_Substrings.FindAllSubstringsWithGivenCharacters findAll = new Find_All_Substrings.FindAllSubstringsWithGivenCharacters();
            findAll.FindingThroughBruteSearch(input.randomString, input.randomSubString);

            FizzBuzz fizzBuzz = new FizzBuzz();
            Console.WriteLine(fizzBuzz.FizzBuzzFunction(15)); 
             
            ReverseOnlyAlphabet reverseOnlyAlphabet = new ReverseOnlyAlphabet();
            Console.WriteLine(reverseOnlyAlphabet.ReverseAlphabet("sea!$hells3"));

            Anagram anagram = new Anagram();
            Console.WriteLine("Is cinema and iceman anagram: " + anagram.IsAnagram("cinema", "iceman"));
            Console.WriteLine("Is cinema and anemic anagram: " + anagram.IsAnagram("cinema", "anemic"));
            Console.WriteLine("Is cinema and micael anagram: " + anagram.IsAnagram("cinema", "micael"));

            Pallindrome pallindrome = new Pallindrome();
            Console.WriteLine("Is thisisnotapallindrome a pallindrome: " + pallindrome.IsPallindrome("thisisnotapallindrome"));
            Console.WriteLine("Is 'a' a pallindrome: " + pallindrome.IsPallindrome("a"));
            Console.WriteLine("Is racecar a pallindrome: " + pallindrome.IsPallindrome("racecar"));
            Console.WriteLine("Is rac1*e*1car a pallindrome: " + pallindrome.IsPallindrome("rac1*e*1car"));
            Console.WriteLine("Is rac12&~@^*e*21car a pallindrome(without the non-alphanumeric characters): " + pallindrome.IsPallindrome("rac12&~@^*e*21car", true));
            Console.WriteLine("Is 'A Santa Lived As a Devil At NASA' a pallindrome: " + pallindrome.IsPallindrome("A Santa Lived As a Devil At NASA"));
            
            Arrays_Concept.Majority_Element majority = new Arrays_Concept.Majority_Element();
            Console.WriteLine("Majority Element in [3, 3, 4, 2, 4, 4, 2, 4, 4] is: " + majority.FindMajorityElement(new int[] { 3, 3, 4, 2, 4, 4, 2, 4, 4 })); // 4 is the majority element
            Console.WriteLine("Majority Element in [3, 3, 4, 2, 4, 4, 2, 4] is: " + majority.FindMajorityElement(new int[]  { 3, 3, 4, 2, 4, 4, 2, 4 } )); // No majority element
            
            PowerOfThree powerOfThree = new PowerOfThree();
            Console.WriteLine("Is 3 a power of 3: " + powerOfThree.FindIfNumberIsPowerOfThree(3));
            Console.WriteLine("Is 6 a power of 3: " + powerOfThree.FindIfNumberIsPowerOfThree(6));
            Console.WriteLine("Is 27 a power of 3: " + powerOfThree.FindIfNumberIsPowerOfThree(27));
            Console.WriteLine("Is 7 a power of 3: " + powerOfThree.FindIfNumberIsPowerOfThree(7));

            Arrays_Concept.Single_Lonely_Number lonely_Number = new Arrays_Concept.Single_Lonely_Number();
            Console.WriteLine("Lonely number in [ 4, 4, 6, 1, 3, 1, 3 ] is: " + lonely_Number.Find(new int[] { 4, 4, 6, 1, 3, 1, 3 })); // 6 
            Console.WriteLine("Lonely number in [ 3, 3, 9 ] is: " + lonely_Number.Find(new int[] { 3, 3, 9 })); // 9

            SumDigitsUntilOne untilOne = new SumDigitsUntilOne();
            Console.WriteLine("Single digit from sum of digits of number 49 recursively is:  " + untilOne.FindSingleDigit(49));
            Console.WriteLine("Single digit from sum of digits of number 50 recursively is:  " + untilOne.FindSingleDigit(50));

             String_Concepts.DetectSubstring detectSubstring = new String_Concepts.DetectSubstring();
            Console.WriteLine("The index at which substring 'flew' is present in string 'thepigflewwow' is: " + detectSubstring.Detect("thepigflewwow", "flew"));
            Console.WriteLine("The index at which substring 'graph' is present in string 'ggraph' is: " + detectSubstring.Detect("ggraph", "graph"));
            Console.WriteLine("The index at which substring 'two' is present in string 'twocanplay' is: " + detectSubstring.Detect("twocanplay", "two"));
            Console.WriteLine("The index at which substring 'graph' is present in string 'geography' is: " + detectSubstring.Detect("geography", "graph"));
            Console.WriteLine("The index at which substring 'inn' is present in string 'digginn' is: " + detectSubstring.Detect("digginn", "inn"));
            Console.WriteLine("The index at which substring 'cat' is present in string 'home is home' is: " + detectSubstring.Detect("home is home", "cat"));
            Console.WriteLine("The index at which substring 'cat' is present in string 'home is where your cat is': " + detectSubstring.Detect("home is where your cat is", "cat"));
            Console.WriteLine("The index at which substring 'cat' is present in string 'home is where your not where your cap is but where your cat is': " + detectSubstring.Detect("home is where your not where your cap is but where your cat is", "cat"));
             
             // Single Linked List
            Data_Structures.LinkedList testList = new Data_Structures.LinkedList();
            testList.InsertFront(testList, 1);
            testList.InsertAfter(testList.head, 2);
            testList.InsertAfter(testList.head.next, 3);
            testList.InsertEnd(testList, 4);
            testList.PrintAllNodes(testList);

            Console.WriteLine();

            Data_Structures.LinkedList testList1 = new Data_Structures.LinkedList();
            testList.InsertEnd(testList1, 1);
            testList.InsertAfter(testList1.head, 2);
            testList.InsertAfter(testList1.head.next, 3);
            testList.InsertFront(testList1, 4);
            testList.PrintAllNodes(testList1);

            Console.WriteLine("\nReversing the List");

            testList.ReverseLinkedList(testList1);
            testList.PrintAllNodes(testList1);

            Console.WriteLine("\nDeleting first node");
            testList.DeleteNodeByKey(testList1, 3);
            testList.PrintAllNodes(testList1);

            Console.WriteLine("\nDeleting last node");
            testList.DeleteNodeByKey(testList1, 4);
            testList.PrintAllNodes(testList1);

            Console.WriteLine("\nDeleting all nodes");
            testList.DeleteNodeByKey(testList1, 2);
            testList.DeleteNodeByKey(testList1, 1);
            testList.PrintAllNodes(testList1);

            Console.WriteLine();

            // Double Linked List
            Data_Structures.DoubleLinkedList testList3 = new Data_Structures.DoubleLinkedList();
            testList3.InsertFront(testList3, 1);
            testList3.InsertAfter(testList3.head, 2);
            testList3.InsertAfter(testList3.head.next, 3);
            testList3.InsertEnd(testList3, 4);
            testList3.PrintAllNodes(testList3);

            Console.WriteLine();

            Data_Structures.DoubleLinkedList testList4 = new Data_Structures.DoubleLinkedList();
            testList3.InsertEnd(testList4, 1);
            testList3.InsertAfter(testList4.head, 2);
            testList3.InsertAfter(testList4.head.next, 3);
            testList3.InsertFront(testList4, 4);
            testList3.PrintAllNodes(testList4);

            Console.WriteLine();

            testList3.ReverseLinkedList(testList4);
            testList3.PrintAllNodes(testList4);

            Console.WriteLine("\nDeleting first node");
            testList3.DeleteNodeByKey(testList4, 3);
            testList3.PrintAllNodes(testList4);

            Console.WriteLine("\nDeleting last node");
            testList3.DeleteNodeByKey(testList4, 4);
            testList3.PrintAllNodes(testList4);

            Console.WriteLine("\nDeleting all nodes");
            testList3.DeleteNodeByKey(testList4, 2);
            testList3.DeleteNodeByKey(testList4, 1);
            testList3.PrintAllNodes(testList4);
             
            Data_Structures.BinaryTree tree = new Data_Structures.BinaryTree();
            tree.Iterative_Insert(tree, 4);
            tree.Iterative_Insert(tree, 2);
            tree.Iterative_Insert(tree, 5);
            tree.Iterative_Insert(tree, 1);
            tree.Iterative_Insert(tree, 3);
            tree.Iterative_Insert(tree, 10);

            tree.Iterative_DisplayInPreOrder(tree);
            tree.Iterative_DisplayInPostOrder(tree);
            tree.Iterative_DisplayInOrder(tree);

            Console.WriteLine();

            tree.Recursive_Insert(tree.root, 7);
            tree.Recursive_Insert(tree.root, 15);
            Console.WriteLine("\n****************Display in Pre Order*****************");
            tree.Recursive_DisplayInPreOrder(tree.root);
            Console.WriteLine("\n****************Display in Post Order*****************");
            tree.Recursive_DisplayInPostOrder(tree.root);
            Console.WriteLine("\n****************Display in InOrder*****************");
            tree.Recursive_DisplayInOrder(tree.root);
            
            // Dollar Sign Deletion
            string[] arr = { "f$st", "st", "f$st$ts$" };
            Arrays_Concept.DollarSignDeletion dollar = new Arrays_Concept.DollarSignDeletion();
            Console.WriteLine(dollar.DeleteCharacterBeforeDollarSign("f$st$ts$"));
            Console.WriteLine(dollar.IsDollarDeleteEqual(arr));

            */

            // First non-repeating character
            String_Concepts.FirstNonRepeatingCharacter first = new String_Concepts.FirstNonRepeatingCharacter();
            string inputString = "asdfsdafdasfjdfsafnnunl";
            Console.WriteLine("\nFind the first non-repeating character in string: " + inputString);
            Console.WriteLine("\nOutput:");
            Console.WriteLine(first.Find(inputString));

            string inputString1 = "asdfsda1fdasfjd22fsafnnunl";
            Console.WriteLine("\nFind the first non-repeating character in string: " + inputString1);
            Console.WriteLine("\nOutput:");
            Console.WriteLine(first.Find(inputString1));

            string inputString2 = "aaddff4455";
            Console.WriteLine("\nFind the first non-repeating character in string: " + inputString2);
            Console.WriteLine("\nOutput:");
            Console.WriteLine(first.Find(inputString2));
        }
    }
}
