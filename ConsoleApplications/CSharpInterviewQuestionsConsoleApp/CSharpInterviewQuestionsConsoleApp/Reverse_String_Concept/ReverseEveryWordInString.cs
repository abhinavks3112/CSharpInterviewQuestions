using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Reverse_String_Concept
{
    class ReverseEveryWordInString
    {
        // Reversing each word in a string using built in functions
        public void ReverseEveryWordWithBuiltInMethod()
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();

            /*
             * Used split function to split string into words on the basis of single space separator
             * which gave us a string array of words.
             * Used Lambda expression to select each word and reversed it using Reverse function which
             * gave us IEnumerable of characters.
             * Converted IEnumerable of characters to character array.
             * Converted the character array to string, so each word is now reversed and is also a string.
             * Used String's Join function to join each word string with single space separator.
             */
            string resultString = string.Join(" ", 
                str.Split(' ').
                Select(word => new String(word.Reverse().ToArray())));

            Console.WriteLine("Result of reversing every word in string with built in methods: " + resultString);
        }

        // Reversing each word in a string without using built in functions
        public void ReverseEveryWordWithoutBuiltInMethod()
        {
            Console.WriteLine("Enter any string");
            string str = Console.ReadLine();

            /*
             * Used SplitStringIntoIndividualWords function to split string into words on the basis of 
             * single space separator which gave us a List of words.
             * Used Lambda expression to select each word and reversed it using our ReverseSingleWord
             * function which gave us a reverse word string
             * The whole expression gave us IEnumerable of string consisting of reversed words.
             * Converted it into a list and passed it to our function JoinAllString to join and give us an output.
             */
            string resultString = JoinAllString(SplitStringIntoIndividualWords(str, ' ').Select(word => ReverseSingleWord(word)).ToList(), " ");

            Console.WriteLine("Result of reversing every word in string without built in methods: " + resultString);
        }

        public string JoinAllString(List<string> wordsList, string separator)
        {
            StringBuilder builder = new StringBuilder();
            int index = 0;
            int lastIndex = wordsList.Count - 1;
            foreach (string word in wordsList)
            {
                builder.Append(word);
                if(index != lastIndex)
                {
                    builder.Append(separator);
                }
            }
            return builder.ToString();
        }

        public string ReverseSingleWord(string word)
        {
            char[] letterInWords = word.ToCharArray();
            char[] letterInWordsReverse = new char[letterInWords.Length];

            int counter = 0;
            for (int i = letterInWords.Length -1; i >= 0; i--)
            {
                // Storing the character starting from the last character to first character in a new array hence reversing it
                letterInWordsReverse[counter] = letterInWords[i];
                counter++;
            }
            return new String(letterInWordsReverse);
        }

        public string RevereseSingleWordUsingTwoPointer(string word)
        {
            char[] letterInWords = word.ToCharArray();

            int startIndex = 0;
            int lastIndex = word.Length - 1;
            char temp;

            while(startIndex <= lastIndex)
            {
                // Swap letters in pair of beginning and end till we reach the middle
                // Decrease the number of operations in half compared to ReverseSingleWord
                // Complexity is O(n) same as ReverseSingleWord
                temp = letterInWords[startIndex];
                letterInWords[startIndex] = letterInWords[lastIndex];
                letterInWords[lastIndex] = temp;
                startIndex++;
                lastIndex--;
            }

            return new String(letterInWords);
        }
        public List<string> SplitStringIntoIndividualWords(string s, char separator)
        {
            StringBuilder temp = new StringBuilder();

            List<string> wordsList = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                // Appending the character till we encounter a separator
                if(s[i] != separator)
                {
                    temp.Append(s[i]);
                    continue;
                }
                // Adding the individual word made of appended characters from above as an individual entry in list
                wordsList.Add(temp.ToString());
                temp.Clear();
            }

            /* 
             * Check if there is any word left in variable(this is the last word) and add it to the list
             * because in last loop above, after it has stored last word, it will reach the string length
             * in index and exit the loop, so "addition to list" statement will get skipped leaving the last
             *  word in buffer or temp variable
             */
            if (!String.IsNullOrEmpty(temp.ToString()))
            {
                // Adding the last word to the list
                wordsList.Add(temp.ToString());
                temp.Clear();
            }
            return wordsList;
        }

    }
}
