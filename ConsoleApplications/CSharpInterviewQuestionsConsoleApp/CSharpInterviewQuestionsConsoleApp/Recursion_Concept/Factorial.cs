using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Recursion_Concept
{
    public class Factorial
    { 
        public double Calculate(int number)
        {
            if(number == 0)
            {
                return 1;
            }

            double factorial = 1;

            /*
             * Eg. If number 3 then 1*3=3, 3*2 = 6, 6 * 1 = 6
             */
            Console.WriteLine("Step in calculating factorial by looping:");
            for (int i = number; i >= 1; i--)
            {
                Console.WriteLine(factorial + " * " + i);
                factorial = factorial * i;
            }

            return factorial;
        }
        public double CalculateByRecursion(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            /*
             * Eg. If number 3 then 3 * CalculateByRecursion(2) * (2 * CalculateByRecursion(1)) * (1 * CalculateByRecursion(0)),
             * last one will 1 so, 3 * 2 * 1 = 6
             */
            Console.WriteLine("Step in calculating factorial by recursion:");
            Console.WriteLine(number + "*" + "Factorial("+ (number - 1) + ")");
            return number * CalculateByRecursion(number-1);
        }
    }
}
