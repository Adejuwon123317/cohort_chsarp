using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    //access modifier: helps in the visibility of members of a class
      class Ademodifier
    {
        //members of a class
        //fields
        //properties
        //constructors
        //method
        //destructors
        //indexers

        //types of access modifiers
        //public-visibility is everywhere any class or method can have access to it
        //private-no other class can have access to it apart from that class and without any access modifier it is automatically a private access mdifier
        //protected-if a class is protected u can inherit from it if its not you cant use it in another class
        //internal - only accessible within its own assembly

        //field
        public static int x = 80;
        public string Name { get; set; }//property
        //constructors
        public Ademodifier()
        {
        }

        //methods
        public static void class1()
        {

        }
        private static void class2()
        {

        }
        protected static void class3()
        {

        }
        internal static void class4()
        {

        }
        public static void class5(int i, string y, double x)
        {
            if (i == 67 && y == "password" && x == 22.5)
            {
                Console.WriteLine("welcome adejuwon");
            }
            else
            {
                Console.WriteLine("password declined");
            }
        }
        public static int class6(int x, int y)
        {
            return x + y;
        }

    }
}
