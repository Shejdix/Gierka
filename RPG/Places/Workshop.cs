using Gierka.Armory;
using Gierka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gierka.Buildings;
using Gierka.Dashboards;
using Gierka.Tools;

namespace Gierka.Places
{
    public class Workshop
    {
        public static List<House> AllHouses;
        public static void LoadWorkshop(Player p, SettStats s)
        {
            RunWorkshop(p, s);
        }
        public static void RunWorkshop(Player p, SettStats s)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("                  Workshop                 ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|     (B)uild              (U)pgrade      |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                (E)xit                   |");
                Console.WriteLine("|                                         |");
                Console.WriteLine(" ----------------------------------------- ");

                string input = Console.ReadLine().ToLower();
                if (input == "b" || input == "build")
                {
                    BuildMenu(p, s);
                }
                else if (input == "u" || input == "upgrade")
                {
                    //UpgradeMenu()
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    Settlement.LoadSettlement(p, s);
                }
            }
        }

        public static void BuildMenu(Player p, SettStats s)
        {

            Console.Clear();
            Console.WriteLine("                  Workshop                 ");
            Console.WriteLine(" ----------------------------------------- ");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|    (H)ouse            (F)arm Field      |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|    (M)ining Hall      (S)acred Spot     |");
            Console.WriteLine("|                                         |");
            Console.WriteLine("|                (E)xit                   |");
            Console.WriteLine("|                                         |");
            Console.WriteLine(" ----------------------------------------- ");

            string input = Console.ReadLine().ToLower();
            if (input == "h" || input == "house")
            {
                HouseShop(p, s);
            }
            else if (input == "f" || input == "farm" || input == "farm field")
            {

            }
            else if (input == "m" || input == "mining" || input == "mining hall")
            {

            }
            else if (input == "s" || input == "sacred" || input == "sacred spot")
            {

            }
            else if (input == "e" || input == "exit")
            {
                Settlement.LoadSettlement(p, s);
            }



        }

        public static void HouseShop(Player p, SettStats s)
        {
            int c = p.coins;
            int P = s.PeopleCount;
            int w = s.Wood;
            int r = s.RawMat;
            int n = 0;

            bool condition = true;


            while (condition)
            {
                if (n >= House.AllHouses.Count)
                {
                    n = 0;
                }


                House selectedHouse = House.AllHouses[n];
                string hName = selectedHouse.Name;

                Console.Clear();
                Console.WriteLine("                  Houses                   ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|  Coins: " + $"{c,3}" + "               Wood: " + $"{w,3}" + "     |");
                Console.WriteLine("|           Raw Materials: " + $"{r,3}" + "            |");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                House.HouseInfo(selectedHouse);
                Console.WriteLine("|                                         |");
                Console.WriteLine("|          (B)uy          (N)ext          |");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("");
                string choice = Console.ReadLine();
                if (choice == "b" || choice == "buy")
                {
                    //Maybe in future :)
                }
                else if (choice == "n" || choice == "next")
                    n++;
                else if (choice == "e" || choice == "exit")
                    condition = false;


            }





            //Tools





        }

    }
}
