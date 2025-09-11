using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{ 
    //xml documentation
    /// <summary>
    /// for getting info about users
    /// </summary>
    public class Information
    {
        /// <summary>
        /// this method is for confirming age 
        /// </summary>
        /// <param name="Age"></param>
        /// <exception cref="Exception"></exception>
        public static void ConfirmAge(int Age)
        {
            if(Age < 18)
            {
                throw new Exception("Access Denied must be at least 18 years old");
            }
            else
            {
                Console.WriteLine("Access granted you are welcome to the fun party!");
            }

        }
        [Obsolete("this method is depricated use new one instead")]
        public static void OldMethod()
        {
            Console.WriteLine("this is an old method");
        }
    }
}
