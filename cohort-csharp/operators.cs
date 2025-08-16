using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp //project name
{
    
    public class operators //class name
    //arithmetic operators +,-,*,/,%,++,--
    //assignment operators =,+=,-=,*=,/=,%=,!=
    //comparism operators ==,!=,>,<,>=,<=
    //logical operators &&,||,!
    {
        //method
        static int value = 45;
        static int value2 = 50;
        public static void MyMethod1()
        {
            int v = 90;
            int x = 34;
            var data = v - x;
            Console.WriteLine(data);

        }
        public static void MyMethod2()

        {
            var result = value + value2;
            Console.WriteLine(result);

        }
        public static void MyMethod3()

        {
            var data = value * value2;
            Console.WriteLine(data);
        }
        static int x = 45; // single variable
        static int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, };//array meaning the collection of values
        public static void MyMethod() //method
        {
            foreach (var v in values)
            {
                Console.WriteLine(v);
            }

        }
    }
}
