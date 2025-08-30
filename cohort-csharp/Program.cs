// See https://aka.ms/new-console-template for more information
using cohort_csharp;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Threading.Channels;

List<Employee> employees = new List<Employee>();
employees.Add(new Employee() { Id = 101, Name = "Ben", Experience = 4, Salary = 300000 });
employees.Add(new Employee() { Id = 102, Name = "Grace", Experience = 5, Salary = 900000 });
employees.Add(new Employee() { Id = 103, Name = "Juwon", Experience = 8, Salary = 240000 });
employees.Add(new Employee() { Id = 104, Name = "Azoka", Experience = 6, Salary = 10000000 });
employees.Add(new Employee() { Id = 105, Name = "Ire", Experience = 6, Salary = 850000 });
employees.Add(new Employee() { Id = 106, Name = "Precious", Experience = 7, Salary = 15000000 });
ispromotable promo = new ispromotable(promote);

Employee.PromoteEmployee(employees,promo);

static bool promote(Employee employee)
{
    if (employee.Salary <= 300000)
    {
        return true;
    }
    else
    {
        return false;
    }
}







//HelloFunction del = new HelloFunction(Calculator2.Hello);
//del("what a delegate world");
















//Console.WriteLine("Hello world");

//var equal = Calculator.AreEqual<string>("67", "89");
//var result = Calculator.AreEqual<int>(54, 78);
//if (equal)
//{
//    Console.WriteLine("the values are equal");
//}
//else
//{
//    Console.WriteLine("the values are not");
//}

