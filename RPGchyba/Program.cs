using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gierka.Buildings;
using Gierka.Dashboards;
using Gierka.Places;

namespace Gierka
{

    public class Program
    {
        public static Player currentPlayer = new Player();
        
        public static bool mainLoop = true;
        static void Main(string[] args)
        { 

            Start();
            Encounters.FirstEncounter();
            while (mainLoop)
            {
                Encounters.RandomEncounter();
            }

        }

        static void Start()
        {
            currentPlayer.BasicInventory();
            Console.WriteLine("Rise of the forgotten gods ");
            Console.WriteLine(" ");
            Console.WriteLine("Your name is: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();

            Shop.LoadShop(currentPlayer);
            currentPlayer.ShowInventory();
            Settlement.LoadSettlement();


            Console.WriteLine("You awaken in a forest, your body marked with glowing runes," +
                " their meaning clear despite your lost memories. ");
            if (currentPlayer.name == "")
            {
                Console.WriteLine("You can't even remeber your own name but a mission " +
                    "- to stop the world's end. ");
                currentPlayer.name = "Zdzisiu";
            }
            else
                Console.WriteLine("Only your name - '" + currentPlayer.name + "' and a mission remain: to stop the world’s end. ");

            Console.WriteLine("Grabbing a long stick for protection, you venture deeper into the ancient woods, " +
            "guided by whispers of forgotten gods." + Environment.NewLine + "Your journey begins.");

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("(Press any key)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("It appeared before your eyes.\r\n Bathed in celestial light," +
                " astride a magnificent white steed, " +
                "gliding slowly into the heart of the city.\r\n" +
                " Its crown shimmered like stardust against " +
                "the vast canvas of the night sky.\r\nThis" +
                " was no mere omen — It was the sign that " +
                "humanity would soon be brought face-to-face" +
                " with its deepest frailties and flaws.");
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("(Press any key)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("After wandering for a long hours, you found a ruins of the village.\r\n " +
                "Pierwsza trąba zebrała swoje żniwa, co tylko przyspieszyło twoje kroki w kierunku postaci w kapturze\r\n" +
                "Przed ruinami stał starszy człowiek, powoli przeczesując swoje wąsy" +
                "Nim się zorientowałeś, starzec zniknął i zerwał się burzliwy wiatr");
            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("(Press any key)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}