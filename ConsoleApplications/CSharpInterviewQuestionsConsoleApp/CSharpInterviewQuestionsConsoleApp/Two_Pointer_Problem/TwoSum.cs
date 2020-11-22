using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Two_Pointer_Problem
{
    /*
     *  Given an array of unsorted integers, 
     *  return the indices of the two numbers along with the numbers in it, that add up to a specific goal number.
     *  Assume that each input would have exactly one solution.
     */
    class TwoSum
    {
        public Dictionary<int, int> FindIndicesAndElements(int[] inputArray, int targetSum)
        {
            bool found = false;

            Dictionary<int, int> complementaryNumber = new Dictionary<int, int>();
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (complementaryNumber.ContainsKey(inputArray[i]))
                {
                    /*
                     * If complementary number is present in dictionary, then store the number in result
                     * dictionary, show the values to the user
                     * and exit the loop.
                     * To get the first number, subtract the current number from sum, store it as key,
                     * and its index as value
                     */
                    result.Add(targetSum - inputArray[i], complementaryNumber[inputArray[i]]);
                    result.Add(inputArray[i], i);

                    Console.WriteLine("First number is: " + (targetSum - inputArray[i]) + " at index: " + complementaryNumber[inputArray[i]]);
                    Console.WriteLine("Second number is: " + inputArray[i] + " at index: " + i);
                    Console.WriteLine("Target sum is: " + targetSum);
                    found = true;
                    break;
                }
                else
                {
                    // Store the difference of value from target sum as key, and index as value
                    // or in other words we are storing the complementary number required for each
                    // element in array to get the target sum
                    complementaryNumber.Add(targetSum - inputArray[i], i);
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
