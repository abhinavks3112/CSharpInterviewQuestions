using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpInterviewQuestionsConsoleApp
{
    /*
     * Can you store different types in an array in c#?
       Yes, 
        1. Using an object array. 
           Here is an example. Since all types inherit (directly or indirectly) from object type,
           we can add any type to the object array, including complex types like Customer,
           Employee etc. We need to override the ToString() method if we want meaningful output
           when ToString() method is invoked.
        2. Using ArrayList class in System.Collections
     */
    class Person
    {
        public int id;
        public string name;

        // To get meaningful output when this class instance is used with ToString
        public override string ToString()
        {
            return this.name;
        }
    }
    class StoringDifferentDataTypesInArray
    {
        public void CreateObjectArray()
        {
            object[] objArray = new object[3];
            objArray[0] = 1; // Assigning simple data type
            objArray[1] = "Hi"; // Assigning simple data type

            Person Mark = new Person() { id = 1, name = "Mark" };

            // Assigning complex data type
            objArray[2] = Mark; // Or Mark.ToString(), since we have overridden ToString, it will give a meaningful output

            foreach (object obj in objArray)
            {
                Console.WriteLine(obj);
            }
        }
        public void CreateArrayList()
        {
            ArrayList objArray = new ArrayList(); // No need to assign size
            // Using Add method of arraylist class to add elements
            objArray.Add(1); // Assigning simple data type
            objArray.Add("Hi"); // Assigning simple data type

            Person Mark = new Person() { id = 1, name = "Mark" };

            // Assigning complex data type
            objArray.Add(Mark); // Or Mark.ToString(), since we have overridden ToString, it will give a meaningful output

            foreach (object obj in objArray)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
