using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Gierka.Dashboards;
using Gierka.Tools;
using Gierka.Buildings;

namespace Gierka.Places
{
    public class Settlement
    {
        
        public static void LoadSettlement(Player p, SettStats s)
        {
            SettField(p,s);
        }

        //View of our sterrlement !
        public static void SettField(Player p, SettStats s)
        {;
            

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"                   {Program.currentSett.Name,10}                        ");
                Console.WriteLine(" -------------------------------------------------------");
                Console.WriteLine("|                                                      |");
                Console.WriteLine($"|                                                      |");
                Console.WriteLine($"|                                                      |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine($"|                     {"[P]",-3}                              |");
                Console.WriteLine($"|                                      {"[S]",-3}             |");
                Console.WriteLine($"|      {"[W]",-3}                                             |");
                Console.WriteLine($"|                                                      |");
                Console.WriteLine($"|                      {"[H]",-3}                             |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine(" -------------------------------------------------------");
                Console.WriteLine("");

                string input = Console.ReadLine().ToLower();
                if (input == "w" || input == "workshop")
                {
                    Workshop.LoadWorkshop(p, s);

                }
                else if (input == "p" || input == "player")
                {
                    PlayerHouse.RunPlayerHouse(p);
                }
                else if (input == "s" || input == "shop" || input == "runes shop")
                {
                    Shop.LoadShop(p);
                }
                else if (input == "h" || input == "house")
                {
                    House.LoadHouse();
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    break;
                }
                
            }
        }

        

        //W for Workshop, P for player house


        //public static void 


    }
}
