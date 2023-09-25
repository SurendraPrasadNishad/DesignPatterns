using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //in multi thread environment
            Parallel.Invoke(
                ()=> EmployeePrintMethod(),
                () => StudentPrintMethod() 
            );
            
        }

        private static void EmployeePrintMethod()
        {
            SingletonPattern emp = SingletonPattern.getIntance;
            emp.PrintDetails("From Employess");
        }
        private static void StudentPrintMethod()
        {
            SingletonPattern std = SingletonPattern.getIntance;
            std.PrintDetails("From Students");
        }
    }
}
