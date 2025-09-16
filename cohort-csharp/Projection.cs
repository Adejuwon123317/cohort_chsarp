using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class Projection
    {
        public static void SelectValue()
        {
            //query syntax
            var data = (from emp in Users.GetUser()
                        select emp.FirstName).ToList();
            foreach (var value in data)
            {
                Console.WriteLine(value);
            }
            //Method synthax
            var data2 = Users.GetUser().ToList();
            var values = data2.OrderBy(x => x.Salary).ThenBy(x => x.FirstName);
            foreach (var value in values)
            {
                Console.WriteLine(value.FirstName + " " + value.LastName + " " + value.Salary);
            }
        }
    }
}


public class Users
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }

    public static List<Users> GetUser()
    {
        List<Users> user = new List<Users>
            {
                new Users{Id = 101, FirstName="Gbenga",LastName="Dele",Salary = 200000 },
                new Users{Id = 102, FirstName="Tom",LastName="Precious",Salary = 450000 },
                new Users{Id = 103, FirstName="Ben",LastName="Victor",Salary = 500000 },
                new Users{Id = 104, FirstName="Shogo",LastName="Mariam",Salary = 200000 },
                new Users{Id = 105, FirstName="Joy",LastName="Divine",Salary = 250000 },
                new Users{Id = 106, FirstName="Mary",LastName="Moyo",Salary = 220000 },
                new Users{Id = 107, FirstName="Bisi",LastName="Chidinma",Salary = 700000 },
                new Users{Id = 108, FirstName="Shola",LastName="Goke",Salary = 500000 },
                new Users{Id = 101, FirstName="Goke",LastName="Bayo",Salary = 550000 },
                new Users{Id = 101, FirstName="Bayo",LastName="Bola",Salary = 200000 },
            };
        return user;
    }
}