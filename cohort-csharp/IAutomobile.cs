using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    interface IAutomobile : IResult 
    {
        string Name { get; set; }
        void MyMethod1();
    }
    interface IResult
    {
        void MyMethod2();
        void MyMethod3();
    }
}
