using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Arrays_Concept
{
    class Majority_Element
    {
        /*
         * Given an array of numbers like the following:
            [4, 2, 4]
            Could you find the majority element?
            A majority is defined as "the greater part, or more than half, of the total. 
            It is a subset of a set consisting of more than half of the set's elements.
            A majority element in an array A[] of size n is an element that appears more than n/2 times
            (and hence there is at most one such element). 
            Let's assume that the array length is always at least one, and that there's always a majority element.
            In the example above, the majority element would be 4.
         * 
         */

        public int FindMajorityElement(int[] arr)
        {
            // Declare a dictionary with distinct number in array serving as key and their number of occurance serving as value
            Dictionary<int, int> numberFrequency = new Dictionary<int, int>();
            int majorityNumber = 0;
            int majorityNumberFrequency = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                // If the dictionary already has the number as key, increase its number of occurance/frequency by 1
                if (numberFrequency.ContainsKey(arr[i]))
                {
                    numberFrequency[arr[i]] += 1; 
                }
                else
                {
                    // If the dictionary doesn't has the number as key, add it as key and initialise its number of occurance as 1
                    numberFrequency.Add(arr[i], 1);
                }
                // If the current majority frequency we have noted is less than the current entry, update and store both number and
                // frequency in separate variables
                if (majorityNumberFrequency <= numberFrequency[arr[i]])
                {
                    majorityNumber = arr[i];
                    majorityNumberFrequency = numberFrequency[arr[i]];
                }
            }

            // If there is a number which appears more than half the number of times compared to length of array, return it as majority number
            if (majorityNumberFrequency > (arr.Length / 2))
            {
                return majorityNumber;
            }

            // If there is no majority return -1 for no majority
            return -1;
        }
    }
}
