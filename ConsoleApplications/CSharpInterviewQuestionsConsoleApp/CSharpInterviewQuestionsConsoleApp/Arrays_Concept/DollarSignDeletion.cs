using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Arrays_Concept
{
    /*
     * Given an array of strings containing alphabetical characters and certain $ characters. A $ represents a 
     * DELETE action whereby the character before it is deleted. Each of these strings will be run through a method to
     * operate on the $ DELETE action. We want to find out if the final string is the same for all of them. 
     * Let's take an example:
        const input = ["f$st", "st"]
        isDollarDeleteEqual(input);
        // true
        // true because both become "st"
        Given the below function signature, can you find a solution in O(n) time and constant space?
        function isDollarDeleteEqual(arr) {
            return;
        }
     */
    class DollarSignDeletion
    {
        public bool IsDollarDeleteEqual(string[] arr)
        {
            int counter = 0;
            string[] temp = new string[arr.Length];
            foreach (var str in arr)
            {
               temp[counter]= DeleteCharacterBeforeDollarSign(str).Trim('\0');
                if(counter > 1)
                {
                    if (!string.Equals(temp[counter], temp[counter - 1], StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
               counter++;
            }
            return true;
        }
        public string DeleteCharacterBeforeDollarSign(string str)
        {
            char[] tempStr = str.ToCharArray();
            char[] output = new char[tempStr.Length];
            int counter = 0;
            for (int i = 0; i < tempStr.Length; i++)
            {
                if (tempStr[i] == '$')
                    continue;
                if (tempStr[i] != '$' && (i + 1) < tempStr.Length && tempStr[i + 1] != '$')
                {
                    output[counter] = tempStr[i];
                    counter++;
                }
                if ((i + 1) == tempStr.Length && tempStr[i] != '$')
                {
                    output[counter] = tempStr[i];
                    counter++;
                }
            }
            return new String(output); // ToString or ConvertToString will not convert char[] to string, use new String(output)/string.Concat(output)/string.Join("", output)
        }
    }
}
