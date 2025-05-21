using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gierka.Dashboards;

namespace Gierka.Armory
{
    public class Armor : Item
    {
        public int Defence { get; set; }

        public Armor(string name, int defence, int cost) : base(name, cost)
        {
            Defence = defence;
        }

        //Available armors
        public static List<Armor> AllArmors = new List<Armor>
        {
            new Armor("Old Caftan", 12, 15),
            new Armor("Rusty Chainmail", 16, 35),
            new Armor("Silver&Leather Set", 20, 55),
        };

        public override void Buy(Player p)
        {
            if (!p.Armors.Any(w => w.Name == Name))
            {
                if (p.runes >= Cost)
                {
                    p.runes -= Cost;
                    p.AddArmor(Name);
                    Console.WriteLine("You bought " + Name + "!");
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine("You don't have enough runes!");
                    Console.WriteLine("");
                    Console.WriteLine("/Press any key/");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Already bought!");
            }

        }
    }
}
