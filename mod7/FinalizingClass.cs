using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class FinalizingClass
    {
        public FinalizingClass() 
        {
            Console.WriteLine($"\tConstructing {GetType().Name}");
        }
        ~FinalizingClass()
        {
            Console.WriteLine($"\tDestructing {GetType().Name}");
        }
    }


}
