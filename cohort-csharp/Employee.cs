using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public delegate bool ispromotable(Employee emp);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> Emplist,ispromotable iseligible)
        {
            foreach (var emp in Emplist)
            {
                if(iseligible(emp))
                {
                    Console.WriteLine(emp.Name + " " + "is promoted");
                }
            }
        }
    }
}
