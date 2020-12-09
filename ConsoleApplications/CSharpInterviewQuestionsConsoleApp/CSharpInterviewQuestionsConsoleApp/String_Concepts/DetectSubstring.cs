using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.String_Concepts
{
    class DetectSubstring
    {
        /*
         * If the substring can be found in the string, return the index at which it starts. Otherwise, return -1.
            function detectSubstring(str, subStr) {
              return -1;
            }
            Important-- do not use the native String class's built-in substring or substr method
         */
        public int Detect(string str, string subStr)
        {
            int counter, substr_Match_Start_Index = -1;
            bool incremented = false;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] != subStr[0])
                {
                    // Continue if the first letter of substring is not matching with the current letter in the string
                    continue;
                }
                else
                {
                    counter = 0;
                    // Store the index value where first letter of substring is matched
                    substr_Match_Start_Index = i;
                    // Start comparing and matching letter by letter till the length of substring
                    while (counter < subStr.Length)
                    {  
                        // If any letter doesn't match before length of substring is reached, stop comparing
                        if (str[i] != subStr[counter])
                        {
                            break;
                        }
                        else
                        {
                            counter++;
                            i++;
                            incremented = true;
                        }
                    }
                    if(incremented)
                    {
                        // Since it will be again increase in for loop, we will end up skipping an index
                        // so to compensate, we will decrease it by 1 in case we incremented it for our purpose
                        i--;
                    }
                    // If all letters match till the length of substring is reached, return the start index of substring
                    if (counter == subStr.Length)
                    {
                        return substr_Match_Start_Index;
                    }
                    else
                    {
                        // Indicate this is not the start index we want since the substring didn't fully match
                        substr_Match_Start_Index = -1;
                    }
                }
            }
            return substr_Match_Start_Index;
        }
    }
}
