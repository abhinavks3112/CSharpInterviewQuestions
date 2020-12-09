using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    class SumDigitsUntilOne
    {
        /*
         * Provided a positive integer num. Can you write a method to repeatedly add all of its digits until the result has only one digit?
            Here's an example: if the input was 49, we'd go through the following steps:
            // start with 49
            4 + 9 = 13

            // move onto 13
            1 + 3 = 4
            We would then return 4.
         */
        public int FindSingleDigit(int num) 
        {
            int n = num;
            int remainder, sum;
            if (n < 10)
            {
                // If the given number is single digit, return it
                return n;
            }
            else
            {
                do
                {
                    sum = 0;
                    while (n > 0)
                    {
                        remainder = n % 10;
                        sum += remainder;
                        n /= 10;
                    }
                    n = sum;
                } while (sum > 9);
            }
            return sum;
        }
    }
}
