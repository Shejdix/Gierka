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

        //Answears form player
        public static void StartDialogue(NPC npc, List<string> playerResponses)
        {
            Console.WriteLine($"{npc.Name}: {npc.Dialogue}");
            Console.WriteLine("Responses:");
            for (int i = 0; i < playerResponses.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playerResponses[i]}");
            }
        }

    }
}
