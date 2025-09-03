using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public delegate void HelloFunction(string message);
    //delegate
    //its a function pointer
    //it is a function type pointer
    public class Calculator2
    {
        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
       
     
    }
}
