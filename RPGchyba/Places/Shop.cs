using RPGchyba.Armory;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGchyba.Places
{

    public static class Shop
    {
        public static void LoadShop(Player p)
        {

            RunShop(p);
        }

        public static void RunShop(Player p)
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine("                 Runic shop                ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|    (W)eapons               (A)rmors     |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                 (E)xit                  |");
                Console.WriteLine("|                                         |");
                Console.WriteLine(" ----------------------------------------- ");

                string input = Console.ReadLine().ToLower();
                if (input == "w" || input == "weapons")
                {
                    WeaponsShop(p);

                }
                else if (input == "a" || input == "armors")
                {
                    ArmorShop(p);
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    break;
                }



            }
        }
        static void Buy(Player p, int cost, ref item)
        {
            if (p.runes >= cost)
            {
                p.runes -= cost;
                Console.WriteLine("You bought " + item +"!" );
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("You don't have enough runes!");
                Console.ReadKey();
            }
        }

        static void WeaponsShop(Player p)
        {
            int r = p.runes;
            int n = 0;
            bool condition = true;

            while (condition)
            {
                if (n >= Weapon.AllWeapons.Count)
                {
                    n = 0;
                }

                Weapon selectedWeapon = Weapon.AllWeapons[n];
                


                Console.Clear();
                Console.WriteLine("                  Weapons                  ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|  Runes: " + $"{r,3}" + "                             |");
                Console.WriteLine("|                                         |");
                ShowWeaponInfo(selectedWeapon);
                Console.WriteLine("|                                         |");
                Console.WriteLine("|          (B)uy          (N)ext          |");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("");
                    string choice = Console.ReadLine();
                    if (choice == "b" || choice == "buy")
                    {
                        Buy();
                        condition = false;
                    }
                    else if (choice == "n" || choice == "next")
                        n++;
                    else if (choice == "e" || choice == "exit")
                        condition = false;

                    
            }
        }
        static void ArmorShop(Player p)
        {
            int r = p.runes;
            int n = 0;
            bool condition = true;

            while (condition)
            {
                if (n >= Weapon.AllWeapons.Count)
                {
                    n = 0;
                    break;
                }

                Armor selectedArmor = Armor.AllArmors[0];

                Console.Clear();
                Console.WriteLine("                   Armors                  ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|  Runes: " + $"{r,3}" + "                        Cost:   |");
                Console.WriteLine("|                                         |");
                ShowArmorInfo(selectedArmor);
                Console.WriteLine("|                                         |");
                Console.WriteLine("|          (B)uy          (N)ext          |");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("");

                ShopMenu(ref condition, ref n);
            }
        }

        public static void ShowWeaponInfo(Weapon weapon)
        {
            Console.WriteLine($"|  Name: {weapon.Name,-24}         |");
            Console.WriteLine($"|  Attack: {weapon.Attack,-24}       |");
            Console.WriteLine($"|  Cost: {weapon.Cost,-24}         |");
        }
        public static void ShowArmorInfo(Armor armor)
        {
            Console.WriteLine($"|  Name: {armor.Name,-24}        |");
            Console.WriteLine($"|  Defence: {armor.Defence,-24}     |");
            Console.WriteLine($"|  Cost: {armor.Cost,-24}        |");
        }

    }

}