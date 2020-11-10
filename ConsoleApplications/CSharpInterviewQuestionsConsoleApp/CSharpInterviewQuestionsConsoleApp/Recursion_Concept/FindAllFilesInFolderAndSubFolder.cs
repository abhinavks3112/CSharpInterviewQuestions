using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpInterviewQuestionsConsoleApp.Recursion_Concept
{
    class FindAllFilesInFolderAndSubFolder
    {
        public void GetAllFilesInDirectories(string path)
        {
            Console.WriteLine("File(s):");
            foreach (string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(Path.GetFileName(fileName));
            }

            Console.WriteLine();
            
            foreach (string directoryName in Directory.GetDirectories(path))
            {
                Console.WriteLine("Directory:");
                Console.WriteLine(Path.GetFileName(directoryName));
                Console.WriteLine();
                GetAllFilesInDirectories(directoryName);
            }
            Console.WriteLine();
        }
    }
}
