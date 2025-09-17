using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    public class ManU_Football
    {
        public static void Value()
        {
            ///<summary>
            ///to print the First and last name of manu footballers
            ///</summary>
            var data = (from foot in Footballers.GetFootballers()
                        select new { foot.FirstName, foot.LastName });
            foreach (var result in data)
            {
                Console.WriteLine(result);
            }
            
        }
    }

    public class Footballers
    {
        /// <summary>
        /// This Class Has Properties to strore values of Manu footballers 
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int Number { get; set; }
        
        public static List<Footballers> GetFootballers()
        {
            /// <summary>
            /// this method contains the values of manu footballers initialized to the properties 
            /// </summary>
            List<Footballers> players = new List<Footballers>()
            {
                new Footballers{FirstName ="Andre", LastName="Onana", Role="Goalkeeper", Number=24 },
                new Footballers{FirstName ="Diogo", LastName="Dalot", Role="Defender", Number=20 },
                new Footballers{FirstName ="Lisandro", LastName="Martinez", Role="Defender", Number=6 },
                new Footballers{FirstName ="Raphael", LastName="Varane", Role="Defender", Number=19 },
                new Footballers{FirstName ="Luke", LastName="Shaw", Role="Defender", Number=23 },
                new Footballers{FirstName ="Casemiro", LastName="Casemiro", Role="Midfielder", Number=18 },
                new Footballers{FirstName ="Bruno", LastName="Fernandes", Role="Midfielder", Number=8 },
                new Footballers{FirstName ="Christian", LastName="Eriksen", Role="Midfielder", Number=14 },
                new Footballers{FirstName ="Marcus", LastName="Rashford", Role="Forward", Number=10 },
                new Footballers{FirstName ="Rasmus", LastName="Hojlund", Role="Forward", Number=11 }
            };
            return players;
        }
    }
}
