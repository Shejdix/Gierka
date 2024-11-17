using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchyba.Armory
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Cost { get; set; }

        public Weapon(string name, int damage, int runes)
        {
            Name = name;
            Attack = damage;
            Cost = runes;
        }

        //Available weapons
        public static List<Weapon> AllWeapons = new List<Weapon>
        {
            new Weapon("Rusty Sword", 8, 20),
            new Weapon("Nice Axe", 12, 40),
            new Weapon("Enchanted Big Ciupaga", 28, 60)
        };

        //Eq weapons
        


    }
}
