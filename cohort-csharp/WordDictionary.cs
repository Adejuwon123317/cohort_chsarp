using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cohort_csharp
{
    /// <summary>
    /// This class creates words and its meaninful meanings 
    /// </summary>
    public class WordDictionary
    {
        /// <summary>
        /// This method stores the Tkey and the Tvalue of the WordDictionary
        /// </summary>
        public static void MyMethod()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            Console.WriteLine("\t\t\t\tWELCOME TO ADEJUWON WORDS AND MEANING\n\t\t\t\t");
            dict.Add("Abandon:", "To Leave Something Or Somebody\n");
            dict.Add("Candid:", "\tHonest And Strainghtforward\n");
            dict.Add("Dwell:", "\tTo live In A Place\n");
            dict.Add("Eager:", "\tVery Excited To Do Something\n");
            dict.Add("Fragile:", "Easily Broken Or Damaged\n");
            dict.Add("Gloomy:", "\tDark,Sad,Or Without Hope\n");
            dict.Add("Humble:", "\tBeing Modest; Not Proud\n");
            dict.Add("Idle:", "\tNot Active Or Doing Nothing\n");
            dict.Add("Jovial:", "\tCheerful And Full Of Good Humor\n");
            dict.Add("Keen:", "\tVery Intrested Eager Or Sharp\n");

            foreach(var item in dict)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
        }
    }
}
