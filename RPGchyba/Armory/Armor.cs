using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchyba.Armory
{
    public class Armor
    {
        public string Name { get; set; }
        public int Defence { get; set; }
        public int Cost { get; set; }   

        public Armor(string name, int defence, int runes)
        {
            Name = name;
            Defence = defence;
            Cost = runes;
        }

        //Available armors
        public static List<Armor> AllArmors = new List<Armor>
        {
            new Armor("Old Caftan", 12, 15),
            new Armor("Rusty Chainmail", 16, 35),
            new Armor("Silver&Leather Set", 20, 55),
        };
       


    }
}
