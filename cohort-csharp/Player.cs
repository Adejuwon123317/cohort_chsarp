using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class Player
    {
        public string Name = "Adejuwon";
        public int Age = 21;
        public int Score = 0;

        public void Displayinfo()
        {
            Console.WriteLine("The player's name is " + Name);
            Console.WriteLine("The player's age is " + Age);
            Console.WriteLine("The player's score is " + Score);

        }
        public void Levelup()
        {
            Console.WriteLine("Levelling up....");
             Score += 10;

        }
    }
}
