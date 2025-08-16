using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class Car : IAutomobile
    {
        public static void Booth()
        {
            Console.WriteLine();
        }
    }

    public class Bus : Car
    {
    }
}
