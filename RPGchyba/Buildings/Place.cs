using Gierka.Armory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Buildings
{
    public class Place
    {
        public string Name { get; set; }

        public Place(string name)
        {
            Name = name;
        }

        public static List<Place> FreePlaces = new List<Place>
        {
            new Place(""),
            new Place(""),
            new Place(""),
            new Place(""),
        };
    }
}
