using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    /*
     * What is jagged array
       A jagged array is an array of arrays.

        Let us understand jagged array with an example.
        1. There are 3 employees - Mark, Matt, John
        2. Mark has a bachelor, master and doctrate degree (3 qualifications)
        3. Matt has only a bachelor degree (1 qualification)
        4. John has a bachelor and a master degree (2 qualifications)

        Different employees have different number of qualifications. 
        To store their qualifications in a data structure, Jagged array is one of the choices.

        In this example, we have created an array of string arrays. 
        In a similar way, we create an array of integer arrays, an array of decimal arrays etc.
     */
    class JaggedArray
    {
        public void CreateJaggedArray()
        {
            string[] employee = new string[3] { "Mark", "Mat", "John" };

            // Specifying the size of Jagged Array
            string[][] jArray = new string[3][];

            // Specifying the size of array in each element of jagged array
            jArray[0] = new string[3];
            jArray[1] = new string[1];
            jArray[2] = new string[2];

            // Assigning data to each array in jagged array
            jArray[0][0] = "Bachelor";
            jArray[0][1] = "Master";
            jArray[0][2] = "Doctrate";

            jArray[1][0] = "Bachelor";

            jArray[2][0] = "Bachelor";
            jArray[2][1] = "Master";

            for (int i = 0; i < jArray.Length; i++)
            {
                Console.WriteLine(employee[i]);
                Console.WriteLine("--------------------------------");
                for (int j = 0; j < jArray[i].Length; j++)
                {
                    Console.WriteLine(jArray[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
