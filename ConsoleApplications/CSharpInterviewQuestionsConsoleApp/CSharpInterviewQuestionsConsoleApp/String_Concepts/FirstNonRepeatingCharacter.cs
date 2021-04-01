using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.String_Concepts
{
    class FirstNonRepeatingCharacter
    {
        /*
         * You're given a string of random alphanumerical characters with a length between 0 and 1000.
         * Write a method to return the first character in the string that does not repeat itself later on.
            firstNonRepeat('asdfsdafdasfjdfsafnnunl') should return 'j'
         */
        public char Find(string str)
        {
            /*
             * Create a dictionary of each encountered character and increase their occurance count(beginning from 1)
             * everytime their exact repeat is encountered
             */
            Dictionary<char, int> characterAndCount = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!characterAndCount.ContainsKey(str[i]))
                {
                    characterAndCount.Add(str[i], 1);
                }
                else
                    characterAndCount[str[i]]++;
            }
            foreach (KeyValuePair<char, int> item in characterAndCount)
            {
                // Select the first character whose count is 1 that is this is non repeating and exit
                if(characterAndCount[item.Key] == 1)
                {
                    return item.Key;
                }
            }
            return char.MinValue;
        }
    }
}
