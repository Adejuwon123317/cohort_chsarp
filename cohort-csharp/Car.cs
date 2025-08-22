using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    //derived class
    public class Car
    {
        public int Carid;
        public string Carname;
        public string Caryear; //fields
        public DateTime CarDate;

        //constructor
        public Car(int id, string name,string year, DateTime date)
        {
            Carid = id;
            Carname = name;
            Caryear = year;
            CarDate = date;

        }
        public static void MyMethod()
        {
            Console.WriteLine("My name");
        }
  
    }
        
}
