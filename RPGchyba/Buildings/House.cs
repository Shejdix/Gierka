using Gierka.Armory;
using Gierka.Dashboards;
using Gierka.Buildings;
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
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Wood { get; set; }
        public int RawMaterials { get; set; }

        public List<House> OwnedHouses { get; private set; }

        //for the future
        public static List<House> AllHouses = new List<House>
        {
            new House(5,"Hut","[H]",20,15,5),
            new House(10,"Cottage","[C]",40,30,10),
            new House(15,"Residence","[R]",60,45,20)
        };

        public static void HouseInfo(House house)
        {
            Console.WriteLine($"| Name: {house.Name,-17}                 |");
            Console.WriteLine($"| People: {house.People,-3}                             |");
            Console.WriteLine($"| Cost: {house.Cost - 3}                                |");
            Console.WriteLine($"| Wood: {house.Wood,-3}                               |");
            Console.WriteLine($"| RawMaterials: {house.RawMaterials,-3}                       |");

        }

        public House(int people, string name, string position, int cost, int wood, int rawMat) : base(position)
        {
            People = people;
            Cost = cost;
            Wood = wood;
            RawMaterials = rawMat;
        }

        public static void LoadHouse()
        {
            RunHouse();
        }

        public static void RunHouse()
        {

        }
    }

        


}
