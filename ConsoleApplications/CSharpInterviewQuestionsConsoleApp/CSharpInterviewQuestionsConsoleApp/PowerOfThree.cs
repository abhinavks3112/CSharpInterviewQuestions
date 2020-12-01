using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    public class PowerOfThree
    {
        /*
         * Given an integer num, write a method to determine if it is a power of 3.
         */
        public bool FindIfNumberIsPowerOfThree(int num)
        {
            int n = num;
            int remainder;

            while(n > 0)
            {
                remainder = n % 3;

                // In case the number is power of 3, the last number we will get after we keep dividing it by 3 will be 3
                // which will give a remainder of 0 and quotient of 1
                if (remainder == 0 && n/3 == 1)
                {
                    return true;
                }

                n /= 3;
            }
            return false;
        }
    }
}
