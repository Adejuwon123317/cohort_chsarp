using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class ElementOperator
    {
        public static void ElementMethod()
        {
            int[] element1 = { 1, 2, 3, 4, 5, };
            int[] element2 = { };

            var first = element1.Last();
            Console.WriteLine(first);
            var last = element1.LastOrDefault();
            Console.WriteLine(last);
            var element = element1.ElementAtOrDefault(3);
            Console.WriteLine(element);
        }
    }
}
