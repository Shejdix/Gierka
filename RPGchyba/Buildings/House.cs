using Gierka.Armory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Buildings
{
    public class House : Place
    {
        public int People { get; set; }
        public string Position { get; set; }
        public int Cost { get; set; }
        public int Wood { get; set; }
        public int RawMaterials { get; set; }
        public House(int people, string name, string position, int cost, int wood, int rawMat) : base(name)
        {
            People = people;
            Position = position;
            Cost = cost;
            Wood = wood;
            RawMaterials = rawMat;
        }

        //Options of houses
        public static List<House> AllHouses = new List<House>
        {
            new House(5,"Hut","[H]",20,15,5),
            new House(10,"Cottage","[C]",40,30,10),
            new House(15,"Residence","[R]",60,45,20)
        };



        public static void ChooseHouse()
            {
            Console.WriteLine("");
            Console.WriteLine("");
            }

    }   


}
