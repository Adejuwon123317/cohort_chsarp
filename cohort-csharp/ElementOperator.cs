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
            int[] element1 = { 3, 4, 2, 2, 6, 6, 5, 7, 8, 1, 1, 20 };
            int[] element2 = { };

            var first = element1.Last();
            Console.WriteLine(first);
            var last = element1.LastOrDefault();
            Console.WriteLine(last);
            var element = element2.ElementAtOrDefault(3);
            Console.WriteLine(element);
        }
    }
    public class QuantifierOperatorClass
    {
        //any
        //all
        //contain
        public static void AnyMethod()
        {
            int[] element1 = { 3, 4, 2, 2, 6, 6, 5, 7, 8, 1, 1, 20 };

            var anygreatervalue = element1.Any(x => x > 3);
            Console.WriteLine(anygreatervalue);
            
            var allgreatervalue = element1.All(x => x > 3);
            Console.WriteLine(allgreatervalue);

            var cont = element1.Contains(5);
            Console.WriteLine(cont);
        }
    }
    public class aggregate()
    {
        public static void aggregatemethod()
        {
            int[] element1 = { 3, 4, 2, 2, 6, 6, 5, 7, 8, 1, 1, 20 };

            var count = element1.Count(x => x % 2 == 0);
            Console.WriteLine(count);
            var sum = element1.Sum();
            Console.WriteLine(sum);
            var max = element1.Max();
            Console.WriteLine(max);
            var min = element1.Min();
            Console.WriteLine(min);
            var average = element1.Average();
            Console.WriteLine(average);
            
        }
    } 
}

