using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class SetOperators
    {
        public static void SelectSetOperators()
        {
            int[] element1 = { 1, 3, 4, 2, 2, 6, 6, 5, 7, 8, 1, 1, 20 };
            int[] element2 = { 0, 0, 100, 11, 12, 6, 5, 15, 20, 20 };

            var distinct = element1.Distinct();
            Console.WriteLine("distinct" + string.Join(",", distinct));

            var intersect = element1.Intersect(element2);
            Console.WriteLine("Intersect" + string.Join(",", intersect));

            var union = element1.Union(element2);
            Console.WriteLine("union" + string.Join(",", union));

            var concat = element1.Concat(element2);
            Console.WriteLine("concat" + string.Join(",", concat));

            var except = element1.Except(element2);
            Console.WriteLine("except" + string.Join(",", except));

            var sequence = element1.SequenceEqual(element2);
            Console.WriteLine("sequence" + string.Join(",", sequence));
        }
    }
}
