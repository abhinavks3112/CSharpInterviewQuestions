using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Arrays_Concept
{
    class Single_Lonely_Number
    {
        /*
         * Given an array of numbers, one element will show up once and the others will each show up twice. 
         * Can you find the number that only appears once in O(n) linear time? 
         * Bonus points if you can do it in O(1) space as well.
         */
        public int? Find(int[] arr)
        {
            int? lonely_number = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if(lonely_number is null)
                {
                    lonely_number = arr[i];
                }
                else if (lonely_number == arr[i])
                {
                    lonely_number = null;
                }
            }
            return lonely_number;
        }
    }
}
