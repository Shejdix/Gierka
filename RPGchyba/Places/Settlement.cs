using Gierka.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Gierka.Places;
using System.Runtime.CompilerServices;

namespace Gierka.Places
{
    public class Settlement
    {
        
        public static void LoadSettlement()
        {
            SettField();
        }

        public static void SettField()
        {;     

            while (true)
            {
                Console.WriteLine(" -------------------------------------------------------");
                Console.WriteLine("|                                                      |");
                Console.WriteLine($"|                                  {Place.FreePlaces[1].Name,-3}                 |");
                Console.WriteLine($"|           {Place.FreePlaces[3].Name,-3}                                        |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine($"|                     {"[P]",-3}                              |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine($"|      {"[W]",-3}                                             |");
                Console.WriteLine($"|                                      {Place.FreePlaces[2].Name,-3}             |");
                Console.WriteLine($"|                      {Place.FreePlaces[0].Name,-3}                             |");
                Console.WriteLine("|                                                      |");
                Console.WriteLine(" -------------------------------------------------------");
                Console.WriteLine("");

                string input = Console.ReadLine().ToLower();
                if (input == "w" || input == "workshop")
                {
                    Workshop.LoadWorkshop();
                }
                else if (input == "p" || input == "player")
                {
                    ;
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
