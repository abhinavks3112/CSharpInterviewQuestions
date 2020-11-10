using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Abstract_Class_Concept
{
    /*
     * Declaring class as absract
     * 1. No one or no developer can accidently create an instance of base class ie.
     * we don't want base class to be instantiated
     * 2. If instance creation is attempted, it gives compilation error
     * 3. Common functionality of 2 or more classes can be put in abstract class with some
     * conrete method provided and some abstract method to be overridden in child class
     * 4. Abstract concept like BaseEmployee, Shape, etc which do not makes sense on its own,
     * but its specific implementation by child class makes it meaningful eg. PartTimeEmployee
     * for BaseEmployee, Cirle(specific shape) for shape, can be made as abstract. This provides
     * blueprint for what the child class can be.
     */
    public abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        /* Declaring method as abstract 
         * 1. Forces the child class to provide implementation for it,
         * 2. Gives compilation error if not implemented/overridden by child class
         * 3. Base class doesn't have to provide method body/implemtation
         */
        public abstract int GetMonthlySalary();
    }
}
