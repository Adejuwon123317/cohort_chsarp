using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace cohort_csharp
{
    public class Player
    {
        public string Name;
        public int Age;
        public int Score;
        
        public void Userinput()
        {
            Console.WriteLine("What is your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            Age = int.Parse(Console.ReadLine());
            Score = 0;
        }

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
            Console.WriteLine("Congratulations" + " " + Name + " " + "You have successfully levelled up ");

        }
    }
}
