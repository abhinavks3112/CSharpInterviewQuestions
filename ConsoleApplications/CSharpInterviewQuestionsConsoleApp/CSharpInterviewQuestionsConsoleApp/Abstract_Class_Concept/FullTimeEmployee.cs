using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterviewQuestionsConsoleApp.Abstract_Class_Concept
{
    class FullTimeEmployee : BaseEmployee
    {
        public int YearlySalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.YearlySalary/12;
        }
    }
}
