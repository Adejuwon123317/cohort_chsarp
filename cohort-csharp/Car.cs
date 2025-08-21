using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    //derived class
    public class Car : Bus, IAutomobile, IResult
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MyMethod1()
        {
            Console.WriteLine("hello world");
        }

        public void MyMethod2()
        {
           
        }

        public void MyMethod3()
        {
           
        }
    }
    public class Bus : Automobile
    {
    }
}
