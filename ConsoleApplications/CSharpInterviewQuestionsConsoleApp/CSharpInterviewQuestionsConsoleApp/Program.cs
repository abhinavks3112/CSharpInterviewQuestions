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
        }
    }
}
