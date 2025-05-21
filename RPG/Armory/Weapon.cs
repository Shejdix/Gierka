using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gierka.Dashboards;

namespace Gierka.Armory
{
    public class Weapon : Item
    {
        public int Attack { get; set; }

        public Weapon(string name, int damage, int cost) : base(name,cost)
        {
            Attack = damage;
        }

        //Available weapons
        public static List<Weapon> AllWeapons = new List<Weapon>
        {
            new Weapon("Rusty Sword", 8, 20),
            new Weapon("Nice Axe", 12, 40),
            new Weapon("Enchanted Big Ciupaga", 28, 60)
        };

        //Buying weapons
        public override void Buy(Player p)
        {
           if(!p.Weapons.Any(w => w.Name == Name))
            {
                if (p.runes >= Cost)
                {
                    p.runes -= Cost;
                    p.AddWeapon(Name);
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
