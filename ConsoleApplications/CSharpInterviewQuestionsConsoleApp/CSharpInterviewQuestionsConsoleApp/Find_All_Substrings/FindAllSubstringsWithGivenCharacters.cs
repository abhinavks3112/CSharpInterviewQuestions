using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Find_All_Substrings
{
    /*
     * Given a string, find the minimum substring containing all characters in another provided string.
     * Eg. we had a string “HGFDSAXZBJKC” and wanted to find the minimum substring containing
     * all characters in “ABKC”.
     */
    class FindAllSubstringsWithGivenCharacters
    {
        public List<string> FindingThroughBruteSearch(string stringToSearch, string charactersToFind)
        {
            int substringLengthInitial = charactersToFind.Length;
            int counter;
            bool allFound;
            bool increment = false;

            char[] searchString = stringToSearch.ToCharArray();
            List<string> substringList = new List<string>();
            StringBuilder tempWord = new StringBuilder();

            /*
             * Find valid substring in given string, start with minimum length equal to characters to search
             * within the given string, eg. given string “HGFDSAXZBJKC” and substring to search “ABKC”,
             * start with finding all valid substring of length 4 containing "ABKC"
             * and then increase it by 1 till the length of main string ie. 12 ("HGFDSAXZBJKC")
             */
            while (substringLengthInitial < searchString.Length)
            {
                // Reset counter
                counter = 0;

                // Find all substrings with desired length first
                for (int i = 0; i < searchString.Length; )
                {
                    /*
                     * 1. Continue appending letters till it is equal to substring length we are looking for
                     * in this iteration. 
                     * 2. Also, make sure main index on main string doesn't exceed past its
                     * length.
                     */
                    while ((counter < substringLengthInitial) 
                        && (i < searchString.Length))
                    {
                        tempWord.Append(searchString[i]);
                        i++;
                        counter++;
                        increment = true;
                        continue;
                    }
                    /*
                     * 1. For any iteration, the mininmum substring legth should be greater than aur equal to
                     * the number of characters we are looking for eg. "ABKC", minimum substring length can
                     * only be 4 in any iteration to satisfy the criteria.
                     * 2. In each iteration, we want to find all substring of that particular length that we
                     * have decided and in next iteration, we again don't want to test that substring.
                     * Eg. If we have found all substring of length 4 in one iteration then, when finding
                     * all substring of length 5, we have to discard any and all subtring of length less than
                     * 5. So, in any iteration, all our substring length should be equal to mininmum
                     * substring length in THAT iteration.
                     * 
                     */
                    if (tempWord.Length >= charactersToFind.Length && tempWord.Length == substringLengthInitial)
                    {
                        /*
                         * We have formed a substring of desired length, now we need to verify if it contains
                         * all the characters that we are required to have in substring.
                         */
                        allFound = AreMatchingCharactersPresentInGivenString(charactersToFind, tempWord);
                        if (allFound)
                        {
                            /*
                            * If substring contains all the characters that we are required to have,
                            * then check if any duplicate substring exists in the list before
                            * adding to the list of substring.
                            */
                            if (!CheckForDuplicateInList(substringList, tempWord))
                            {
                                substringList.Add(tempWord.ToString());
                            }
                        }
                        /* 
                         * Decrease the counter so that in next iteration it starts forming substring
                         * from the immediate next letter where this time substring started
                         * eg. "HGFDSAXZBJKC", if we are forming substring of 4, then first iteration
                         * should form HGFD, but next iteration shouldn't start after 4, ie. it shouldn't
                         * be SAXZ, instead it should start from next letter from where first substring started
                         * i.e G so GFDS, in this way, we can get all possible continuous letters substrings
                         */
                        i -= (substringLengthInitial - 1);
                    }
                    // Since we are not incrementing in the for loop, we have to take care of it manually in
                    // each iteration
                    if(increment == false)
                    {
                        i++;
                    }
                    counter = 0;
                    tempWord.Clear();
                    increment = false;
                }
                // Increase the substring size to look for by 1
                substringLengthInitial++;
            }

            Console.WriteLine("Provided String: " + stringToSearch);
            Console.WriteLine("Characters to find in given string: " + charactersToFind);
            if (substringList.Count > 0)
            {
                Console.WriteLine("List of substrings in provided string containing the characters");
                foreach (string str in substringList)
                {
                    Console.WriteLine(str);
                }
            }
            else 
            {
                Console.WriteLine("No substrings in provided string contains the given characters");
            }
            return substringList;
        }

        private bool CheckForDuplicateInList(List<string> substringList, StringBuilder tempWord)
        {
            foreach (string str in substringList)
            {
                if (str == Convert.ToString(tempWord))
                    return true;
            }
            return false;
        }

        private static bool AreMatchingCharactersPresentInGivenString(string charactersToFind, StringBuilder tempWord)
        {
            bool allFound = true;
            for (int j = 0; j < charactersToFind.Length; j++)
            {
                if (!tempWord.ToString().Contains(charactersToFind[j]))
                {
                    allFound = false;
                    break;
                }
            }
            return allFound;
        }
    }
}
