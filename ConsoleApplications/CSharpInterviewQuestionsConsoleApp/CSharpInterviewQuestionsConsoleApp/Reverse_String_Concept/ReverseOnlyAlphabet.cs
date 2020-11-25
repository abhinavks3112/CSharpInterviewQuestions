using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Reverse_String_Concept
{
    /*
     * Given a string that contains alphabetical characters (a - z, A - Z) and some other 
     * characters ($, !, etc.). For example, one input may be: 'sea!$hells3'
     * Can you reverse only the alphabetical ones?
       reverseOnlyAlphabetical('sea!$hells3');
      // 'sll!$ehaes3'
     */
    public class ReverseOnlyAlphabet
    {
        public string ReverseAlphabet(string s)
        {
            char[] allChar = s.ToCharArray();
            char temp;

            int pointer1 = 0;
            int pointer2 = allChar.Length - 1;

            /*
             * Using two pointer method to reverse string by exchanging letter from start and end of string
             * but skipping the places where there is no alphabet by incrementing the start index pointer
             * or decrementing the end index pointer as needed.
             */
            while(pointer1 <= pointer2)
            {
                if(!Regex.IsMatch(allChar[pointer2].ToString(), "[a-z]", RegexOptions.IgnoreCase))
                {
                    // Continue decreasing end index pointer until we encounter an alphabet
                    pointer2 -= 1;
                    continue;
                }
                if (!Regex.IsMatch(allChar[pointer1].ToString(), "[a-z]", RegexOptions.IgnoreCase))
                {
                    // Continue increasing start index pointer until we encounter an alphabet
                    pointer1 += 1;
                    continue;
                }

                // Exchange the letters at start and end index pointers
                temp = allChar[pointer2];
                allChar[pointer2] = allChar[pointer1];
                allChar[pointer1] = temp;

                // Move on to next index
                pointer1 += 1;
                pointer2 -= 1;
            }
            return new String(allChar);
        }
    }
}
