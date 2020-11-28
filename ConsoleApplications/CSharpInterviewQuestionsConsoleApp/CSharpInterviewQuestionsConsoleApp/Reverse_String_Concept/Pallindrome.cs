using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Reverse_String_Concept
{
    public class Pallindrome
    {
        /*
         * Given a string str, can you write a method that will return True if is a palindrome and False if it is not?
         * If you'll recall, a palindrome is defined as "a word, phrase, or sequence that reads the same backward as forward".
         * For now, assume that we will not have input strings that contain special characters or spaces, so the following examples hold:
            let str = 'thisisnotapalindrome';
            isPalindrome(str);
            // false

            str = 'racecar';
            isPalindrome(str);
            // true
            For an extra challenge, try to ignore non-alphanumerical characters. 
         */
        public bool IsPallindrome(string str, bool IgnoreNonAlphanumeric = false)
        {
            if (!String.IsNullOrEmpty(str) && !string.IsNullOrWhiteSpace(str))
            {
                string strWithoutSpaces = string.Join("", str.Split(' ')).ToLower();
                if (!IgnoreNonAlphanumeric)
                {
                    ReverseEveryWordInString reverse = new ReverseEveryWordInString();
                    string reverseStr = reverse.ReverseSingleWordUsingTwoPointer(strWithoutSpaces);
                    if (reverseStr == strWithoutSpaces)
                    {
                        return true;
                    }
                }
                else
                {
                    // Regular expression to choose alphabets and numbers
                    string regExpr = "[^a-zA-Z0-9]";
                    // Filter and choose all characters as specified in regular expression and for everything else, replace it with blank character
                    string strWithoutNonAlphanumeric = Regex.Replace(strWithoutSpaces, regExpr, "");
                    string reverseStr = ReverseAlphaNumeric(strWithoutNonAlphanumeric);
                    if (reverseStr == strWithoutNonAlphanumeric)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public string ReverseAlphaNumeric(string s)
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
            while (pointer1 <= pointer2)
            {
                if (!Regex.IsMatch(allChar[pointer2].ToString(), "[a-z][0-9]", RegexOptions.IgnoreCase))
                {
                    // Continue decreasing end index pointer until we encounter an alphabet/number
                    pointer2 -= 1;
                    continue;
                }
                if (!Regex.IsMatch(allChar[pointer1].ToString(), "[a-z][0-9]", RegexOptions.IgnoreCase))
                {
                    // Continue increasing start index pointer until we encounter an alphabet/number
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
