using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gierka.Buildings;
using Gierka.Dashboards;
using Gierka.Places;
using Gierka.Tools;
using System.Text.Json;
using System.IO;

namespace Gierka
{

    public class Program
    {
        public static Player currentPlayer = new Player();
        public static SettStats currentSett = new SettStats();

        public static Player LoadPlayerFromFile(string filePath)
        {
            // Odczyt JSON z pliku
            string jsonString = File.ReadAllText(filePath);

            // Deserializacja JSON do obiektu
            Player currentplayer = JsonSerializer.Deserialize<Player>(jsonString);
            Console.WriteLine("Player loaded from file!");
            return currentplayer;
        }

        public static bool mainLoop = true;
        static void Main(string[] args)
        {
            
            Start();
            //Temporarily
            while (mainLoop)
            {
                Encounters.RandomEncounter();
                
            }

        }

        static void Start()
        {
            Console.WriteLine("Rise of the forgotten gods ");
            Console.WriteLine(" ");
            Console.WriteLine("Your name is: ");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You awaken in a forest, your body marked with glowing runes," +
                " their meaning clear despite your lost memories. ");
            //Two options 
            if (currentPlayer.name == "")
            {
                Console.WriteLine("You can't even remeber your own name but a mission " +
                    "- to save as many people as you can. ");
                currentPlayer.name = "Zdzisiu";
            }
            else
                Console.WriteLine("Only your name - '" + currentPlayer.name + "' and a mission remain: to save as many people as you can. ");

            Console.WriteLine("Grabbing a long stick for protection, you venture deeper into the ancient woods, " +
            "guided by whispers of forgotten gods." + Environment.NewLine + "Your journey begins.");

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine("/Press any key/");
            Console.ReadKey();
            Console.Clear();
            Encounters.FirstEncounter();
            Console.WriteLine("As you manage to defeat the first opponent on your way, you stepped on the right land.");
            Console.WriteLine("You decided to build your shelter for others here, in the forest protected by old gods.");
            Console.WriteLine("");
            Console.WriteLine("/Press any key/");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Name your settlement: ");
            currentSett.Name = Console.ReadLine();
            Console.Clear();

            //NPC dial
            NPC NPC1 = new NPC("NPC1", "Thanks for help!");
            NPC NPC2 = new NPC("NPC2", "Do you know any close shelter?");
            NPC NPC3 = new NPC("NPC3", "Can You help us?");

            List<NPC> npcs = new List<NPC> { NPC1, NPC2 };

            //Dial with one npc
            Dialogue.StartDialogue(NPC1);
            Console.WriteLine("");
            Console.WriteLine("/Press any key/");
            Console.Clear();

            //Dial with many npc
            Dialogue.StartDialogue(npcs);
            Console.WriteLine("");
            Console.WriteLine("/Press any key/");
            Console.Clear();

            //Dial with anwears from player
            List<string> responses = new List<string> { "Yes, you can join me", "Sure, join me" };
            Dialogue.StartDialogue(NPC3, responses);
            Console.WriteLine("");
            Console.WriteLine("/Press any key/");
            Console.Clear();


        }
    }
}