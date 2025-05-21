using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gierka.Tools
{
    public static class Dialogue
    {
        //One npc
        public static void StartDialogue(NPC npc)
        {
            Console.WriteLine($"{npc.Name}: {npc.Dialogue}");
        }

        //Many npc
        public static void StartDialogue(List<NPC> npcs)
        {
            foreach (var npc in npcs)
            {
                Console.WriteLine($"{npc.Name}: {npc.Dialogue}");
            }
        }

        //Answ from player
        public static void StartDialogue(NPC npc, List<string> playerResponses)
        {
            if (npc == null)
            {
                Console.WriteLine("Error: NPC cannot be null.");
                return;
            }
            if (playerResponses == null || playerResponses.Count == 0)
            {
                Console.WriteLine("Error: No responses from player.");
                return;
            }

            //NPC dial
            Console.WriteLine($"{npc.Name}: {npc.Dialogue}");
            Console.WriteLine("Choose a response:");

            //Resp for player
            for (int i = 0; i < playerResponses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playerResponses[i]}");
            }

            //Waiting for choice
            int choice = 0;
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Enter the number of your choice: ");
                string input = Console.ReadLine();

                //Checking if it's number
                if (int.TryParse(input, out choice))
                {
                    //checking answ
                    if (choice >= 1 && choice <= playerResponses.Count)
                    {
                        validChoice = true;
                        Console.WriteLine($"You: {playerResponses[choice - 1]}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!!");
                }
            }

        }
    }
}
