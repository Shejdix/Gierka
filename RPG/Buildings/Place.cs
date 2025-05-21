using Gierka.Armory;
using Gierka.Dashboards;
using Gierka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Buildings
{
    public class Place
    {
        public string Position { get; set; }
        public Place(string position)
        {
            Position = position;
        }



        public virtual void Buy(Player p, SettStats s)
        {
            Console.WriteLine("");
        }

        public virtual void BuildCheck(Player p, SettStats s, House chosenPlace)
        {
            Console.WriteLine("");
        }

        public virtual void UpgradeCheck()
        {
            Console.WriteLine("");
        }

        

    }
}
