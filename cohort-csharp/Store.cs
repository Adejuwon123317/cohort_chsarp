using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public abstract class Store
    {
        //abstract method
        public abstract void Alldata();

        public void Data()
        {
            Console.WriteLine("data");
        }

    }

    public interface Istore
    {
        void Result();
        void chalk();
    }
    public class Myclass 
    {
        
    }
}
