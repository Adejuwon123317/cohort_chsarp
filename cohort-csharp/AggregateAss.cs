using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cohort_csharp
{
    public class AggregateAss
    {
        /// <summary>
        /// A Method To Display All Aggregate Methods.
        /// </summary>
        public static void aggregate()
        {
            double[] element = { 2.0, 3.0, 5.0, 4.0, 7, 8, 12, 16 };

            var count = element.Count(j => j % 2 == 0);
            Console.WriteLine($"\tTotal_Even_Count: {count}\n");
            var sum = element.Sum();
            Console.WriteLine($"\tTotal_Sum: {sum}\n");
            var max = element.Max();
            Console.WriteLine($"\tMax_Value: {max}\n");
            var min = element.Min();
            Console.WriteLine($"\tMin_Value: {min}\n");
            var average = element.Average();
            Console.WriteLine($"\tAverage_Value: {average}\n");
        }
        

    }
}
