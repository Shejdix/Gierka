using Gierka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Armory
{
    public abstract class Item : IBuy
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Item(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public virtual void Buy(Player p)
        {
            if (p.runes >= Cost)
            {
                p.runes -= Cost;
                Console.WriteLine("Succes! You bought " +Name+ "!");
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("You don't have enough runes!");
                Console.ReadKey();
            }
        }
    }
}
