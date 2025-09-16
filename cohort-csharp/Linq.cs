using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    //Language integrated query
    //Query synthax or query expression synthax
    //Method synthax or method expression synthax or fluent synthax
    public class Linq
    {
    }
    public class filtering
    {
        //where
        //of type
        List<int> intlist = new List<int> { 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        public void WhereValue()
        {
            //method syntax
            var filterdata = intlist.Where(x => x > 5);
            foreach (var filter in filterdata)
            {
                Console.WriteLine(filter);
            }
        }
    }
}
