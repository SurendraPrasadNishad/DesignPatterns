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
            SingletonPattern emp=SingletonPattern.getIntance;
            emp.PrintDetails("From Employess");
            SingletonPattern std = SingletonPattern.getIntance;
            std.PrintDetails("From Students");
        }
    }
}
