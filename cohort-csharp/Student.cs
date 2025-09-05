using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public delegate bool ispromoted(Student stud);
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public static void PromoteStudent(List<Student> Stulist,ispromoted isqualified)
        {
            foreach (var stud in Stulist)
            {
                if(isqualified(stud))
                {
                    Console.WriteLine(stud.Name+ " " + "Has been promoted to the next class");
                }
            }
        }
    }
}
//
