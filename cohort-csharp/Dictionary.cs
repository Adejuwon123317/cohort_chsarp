using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class Dictionary
    {
        public static void MyMethod()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Cup");
            dict.Add(2, "Jug");
            dict.Add(3, "Knife");
            dict.Add(4, "Kettle");
            dict.Add(5, "Bottle");
            dict.Add(6, "pot");

            foreach(var item in dict)
            {
                Console.WriteLine("Key:{0} Value : {1}",item.Key, item.Value);
            }

        }
    }
}
