using Gierka.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Places
{
    public class Workshop
    {

        public static void LoadWorkshop()
        {
            RunWorkshop();
        }
        public static void RunWorkshop()
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
                    
                }
                else if (input == "u" || input == "upgrade")
                {
                    
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    Settlement.LoadSettlement();
                }
            }
        }
    }
}
