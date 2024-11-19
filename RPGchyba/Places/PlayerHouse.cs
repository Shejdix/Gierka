using Gierka.Dashboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Places
{
    public class PlayerHouse
    {
        
        public static void RunPlayerHouse(Player p)
        {
            LoadPlayerHouse(p);
        }
        public static void LoadPlayerHouse(Player p)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"          {p.name,10} House               ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|      (S)tats           (I)nventory      |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                 (E)xit                  |");
                Console.WriteLine("|                                         |");
                Console.WriteLine(" ----------------------------------------- ");
                string input = Console.ReadLine().ToLower();
                if (input == "s" || input == "stats" || input == "statistics")
                {
                    Stats(p);
                }
                else if (input == "i" || input == "inventory")
                {
                    Console.Clear();
                    Program.currentPlayer.ShowInventory(p);
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    break;
                }

            }
        }

        public static void Stats(Player p)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("                 Stats                     ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                Player.showstats(p);
                Console.WriteLine("|                 (E)xit                  |");
                Console.WriteLine("|                                         |");
                Console.WriteLine(" ----------------------------------------- ");
                string input = Console.ReadLine().ToLower();
                break;
            }

        }

    }
}
