using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Two_Pointer_Problem
{
    /*
    *  Given an array of sorted integers, 
    *  return the indices of the two numbers along with the numbers in it, that add up to a specific goal number.
    *  Assume that each input would have exactly one solution.
    */
    class TwoSumSortedArray
    {
        public Dictionary<int, int> FindIndicesAndElements(int[] inputArray, int targetSum)
        {
            int pointer1 = 0; // First Index
            int pointer2 = inputArray.Length - 1; // Last Index

            // Setting flag to know whether array is in ascending order or descending order
            bool asc = inputArray[pointer1] < inputArray[pointer2] ? true : false;
            Dictionary<int, int> result = new Dictionary<int, int>();
            bool found = false;

            while (pointer1 < pointer2)
            {
                if (inputArray[pointer1] + inputArray[pointer2] == targetSum)
                {
                    result.Add(inputArray[pointer1], pointer1);
                    result.Add(inputArray[pointer2], pointer2);
                    /*
                     * If sum of elements is equal to targetSum then show the values to the user
                     * and exit the loop 
                     */
                    Console.WriteLine("First element is: " + inputArray[pointer1] + " at index: " + pointer1);
                    Console.WriteLine("Second element is: " + inputArray[pointer2] + " at index: " + pointer2);
                    found = true;
                    break;
                }
                else if (inputArray[pointer1] + inputArray[pointer2] < targetSum)
                {
                    /*
                     * If sum of elements is less than targetSum then advance the left pointer
                     * by 1 if sort order is ascending, so that we can get a higher value number
                     * and vice versa for decending sort order
                     */
                    if (asc)
                        pointer1 += 1;
                    else
                        pointer2 -= 1;
                }
                else if (inputArray[pointer1] + inputArray[pointer2] > targetSum)
                {
                    /*
                     * If sum of elements is greater than targetSum then decrease the right pointer
                     * by 1 if sort order is ascending, so that we can get a lower value number
                     * and vice versa for decending sort order
                     */
                    if (asc)
                        pointer2 -= 1;
                    else
                        pointer1 += 1;
                }
            }
            if (!found)
            {
                Console.WriteLine("Sorry!! No pair exists in array with the given sum: " + targetSum);
            }
            return result;
        }
    }
}
