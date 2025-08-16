using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    //access modifiers for visibility of members of a class
     class Modifiers
    {
        //constructors
        public Modifiers() 
        {
            
        
        }
        //field
        public static int x = 80; 
        public string Name { get; set; }//property


        //members of a class
        //fields
        //methods
        //properties
        //constructors
        //destructors
        //indexers

        //types of access modifiers
        //public-visibility is everywhere any class or method can have access to it
        //private-no other class can have access to it apart from that class and without any access modifier it is automatically a private access mdifier
        //protected-if a class is protected u can inherit from it if its not you cant use it in another class
        //internal - only accessible within its own assembly

        //method
        public static void class1(int i,string y, double x)
        {
            if (i == 102 && y == "Hello" && x == 67.9)
            {
                Console.WriteLine("your pin is correct");
            }
            else 
            {
                Console.WriteLine("invalid password");
            }
        }
        private static int class2()
        {
            return 34;
        }
        public static int class3(int x, int w)
        {
            return x + w;
        }
        public static void class4()
        {

        }
    }
}
