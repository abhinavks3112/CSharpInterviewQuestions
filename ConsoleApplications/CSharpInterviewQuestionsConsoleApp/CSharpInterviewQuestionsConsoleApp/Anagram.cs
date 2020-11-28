using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    public class Anagram
    {

        /*
        *  Definition of an anagram: a word, phrase, or name formed by rearranging the letters
        *  of another: such as cinema, formed from iceman.
        *   Given two strings like "cinema" and "iceman" as inputs. 
        *   Can you write a method isAnagram(str1, str2) that will return true or false
        *   depending on whether the strings are anagrams of each other?
        */
        public bool IsAnagram(string str1, string str2)
        {
            return EfficientMethod(str1, str2);
        }

        private bool InefficientMethod(string str1, string str2)
        {
            // If both are anagram of each other, then first their length should be equal
            if (str1.Length != str2.Length)
                return false;

            Dictionary<char, int> charactersOccuranceString1 = new Dictionary<char, int>();

            // For each unique character, count their number of occurance
            foreach (char c in str1)
            {
                if (charactersOccuranceString1.ContainsKey(c))
                {
                    charactersOccuranceString1[c] += 1;
                }
                else
                {
                    charactersOccuranceString1.Add(c, 1);
                }
            }

            // For each unique character, check if it is present in string1 characters
            // in equal number or not.
            // For this each time matching character of string2 in string1 is encountered
            // decrease the count by 1
            // If more occurance of a particular character in string 2 than string 1,
            // the number will go in negative so its not an anagram
            // If there is any character of string2 missing in string1, then also, its
            // not an anagram
            foreach (char c in str2)
            {
                if (charactersOccuranceString1.ContainsKey(c))
                {
                    if (charactersOccuranceString1[c] < 0)
                    {
                        return false;
                    }
                    charactersOccuranceString1[c] -= 1;
                }
                else
                {
                    return false;
                }
            }

            // If after comparing string2 and string1 character by decreasing the count of 
            // matching character in string1, if all the characters are matched and cancel
            // each other, then its an anagram, otherwise not
            foreach (var item in charactersOccuranceString1)
            {
                if (charactersOccuranceString1[item.Key] != 0)
                {
                    return false;
                }
            }
            return true;
        }
        private bool EfficientMethod(string str1, string str2)
        {
            // Split into characters, sort them and join them again to form a sorted string

            char[] str1Char = str1.ToLower().ToCharArray();
            char[] str2Char = str2.ToLower().ToCharArray();
                       
            Array.Sort(str1Char);
            Array.Sort(str2Char);

            string str1Sorted = new string(str1Char);
            string str2Sorted = new string(str2Char);

            // If anagram, both sorted string should be same
            if (string.Equals(str1Sorted, str2Sorted))
                return true;

            return false;
        }
    }
}
