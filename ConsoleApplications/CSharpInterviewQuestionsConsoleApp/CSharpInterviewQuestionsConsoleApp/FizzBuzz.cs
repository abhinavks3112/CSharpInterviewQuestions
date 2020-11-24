using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp
{
    public class FizzBuzz
    {
        /*
         *  Given a number in the form of an integer n.
            Write a function that returns the string representation of all numbers from 1 to n based on the following rules:
            If it's a multiple of 3, represent it as "fizz".
            If it's a multiple of 5, represent it as "buzz".
            If it's a multiple of both 3 and 5, represent it as "fizzbuzz".
            If it's neither, just return the number itself.
         */
        public string FizzBuzzFunction(int number)
        {
            StringBuilder formFizzBuzzString = new StringBuilder();
            for (int i = 1; i <= number; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    formFizzBuzzString.Append("fizzbuzz");
                }
                else if(i % 3 == 0)
                {
                    formFizzBuzzString.Append("fizz");
                }
                else if(i % 5 == 0)
                {
                    formFizzBuzzString.Append("buzz");
                }
                else
                {
                    formFizzBuzzString.Append(i);
                }
            }
            return formFizzBuzzString.ToString();
        }
    }
}
