using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGchyba
{
    public class Encounters
    {
        static Random rand = new Random();
        //Encounter Generic


        //Encounter 
        public static void FirstEncounter()
        {
            Console.WriteLine("Obróciłeś się i zauważyłeś, że ku tobie biegną" +
                "dwie, półprzeźroczyste postacie bez twarzy.");
            Console.WriteLine("Dwie postacie złączyły się w jedną, znacznie górującą nad tobą");
            Console.WriteLine("Postać uformowała miecz dwuręczny w rękach i zamachnęła się...");
            Combat(false, "Faceless form", 2, 6);
        }
        public static void BasicFightEncounter()
        {
            Console.WriteLine("Suddenly, something is running stright at you...");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }
        public static void ChorsEncounter()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ReadKey();
            Combat(false, "Chors Werewolf", 6, 2);
        }


        //Encounter Tools
        public static void RandomEncounter()
        {
            switch(rand.Next(0,2))
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    ChorsEncounter();
                    break;
            }
        }




        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
                n = GetName();
                p = Program.currentPlayer.GetAttack();
                h = Program.currentPlayer.GetDef();
            }
            else
            {
                n = name;
                p = power;
                h = health;

            }
            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("Power: " + p + " / Health:" + h);

                Console.WriteLine(" ------------------ ");
                Console.WriteLine("|(A)ttack  (D)efend|");
                Console.WriteLine("|(R)un       (H)eal|");
                Console.WriteLine(" ------------------ ");
                Console.WriteLine(" Blessings: "+Program.currentPlayer.blessings + "  Health: "+Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You attack with your full power, but "+n+" strikes you back");
                    int damage = p - Program.currentPlayer.defence;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1,4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("The " +n+ " charges at you, so you took a defensive stance");
                    int damage = (rand.Next(1, 2) * p) - Program.currentPlayer.defence;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(1, Program.currentPlayer.weaponValue)/2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You run away from unsucessfully run away from " +n+ " and it shoved you to the ground.");
                        int damage = (rand.Next(1, 10) * p) - Program.currentPlayer.defence;
                        if (damage < 0)
                            damage = 0;
                        Console.Write("You lose " + damage + " health");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("With use of your runes, you manage to escape from " +n+ ".");
                        Console.ReadKey();
                        //go to safe point
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if(Program.currentPlayer.blessings==0)
                    {
                        Console.WriteLine("As you touched the blessings rune, you felt nothing and realized" +
                            " you used all of them.");
                        Console.WriteLine(n+" take advantage of your distraction and charged at you.");
                        int damage = (p/2) - Program.currentPlayer.defence;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("It strikes you for " +damage+ " health.");
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Console.WriteLine("As you touched the blessing rune, you feel the healing from gods.");
                        int bless = 4;
                        Console.WriteLine("You gained " + bless + " health");
                        Program.currentPlayer.health += bless;
                        Program.currentPlayer.blessings--;
                        int damage = (p / 2) - Program.currentPlayer.defence;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + "struck you for " + damage + "health.");
                    }
                    Console.ReadKey();
                }
                if(Program.currentPlayer.health<=0)
                {
                    //Death
                    Console.WriteLine("You felt dizzy and suddenly everything went to black.");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int r = rand.Next(10, 50); 
            Console.WriteLine("You defeated the " +n+ "and got " +r+ " runes");
            Program.currentPlayer.runes += r;
            Console.ReadKey();
            Console.Clear();
        }

        public static string GetName()
        {
            switch (rand.Next(0, 5))
            {
                case 0:
                    return "Licho";
                case 1:
                    return "zmora";
                case 2:
                    return "widmo";
                case 3:
                    return "utopiec";
                case 4:
                    return "dzikie zwierze Boruta";
                case 5:
                    return "dzika roślina Boruta";
            }
            return "zwierzyna";
        }


    }
}
