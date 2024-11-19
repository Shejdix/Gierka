using Gierka.Armory;
using Gierka.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


namespace Gierka.Dashboards
{
    public class Player
    {
        public List<Armor> Armors { get; private set; }
        public List<Weapon> Weapons { get; private set; }
        public Armor CurrentArmor { get; private set; }
        public Weapon CurrentWeapon { get; private set; }

        Random rand;

        //Stats and info
        public string name { get; set; }
        public int runes { get; set; } = 100;
        public int coins { get; set; } = 200;
        public int health { get; set; } = 10;
        public int damage { get; set; } = 1; //with lvls
        public int weaponValue { get; set; }
        public int defence { get; set; } = 0;
        public int blessings { get; set; } = 5;

        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "playerData.json");

        public static void showstats(Player p)
        {
            Console.WriteLine($"| Name: { p.name,-8}                          |");
            Console.WriteLine($"| Runes: {p.runes,-4}                             |");
            Console.WriteLine($"| Coins: {p.coins, -4}                             |");
            Console.WriteLine($"| Health: {p.health,-4}                            |");
            Console.WriteLine($"| Damage: {p.damage,-4}                            | ");
            Console.WriteLine($"| Current Weapon value: {p.weaponValue,-4}              | ");
            Console.WriteLine($"| Defence: {p.defence, -4}                           | ");
            Console.WriteLine($"| Blessings: {p.blessings, -4}                         | ");
        }

        public static void SavePlayerToFile(Player player, string filePath)
        {
            
            string jsonString = JsonSerializer.Serialize(player, new JsonSerializerOptions { WriteIndented = true });

            //Saving to File
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Player saved to file!");
        }

        //Others

        public int mods = 1;


        //Inventory 
        public Player()
        {
            Armors = new List<Armor>();
            Weapons = new List<Weapon>();
        }

        public void AddArmor(string armorName)
        {
            Armor armor = Armor.AllArmors.Find(a => a.Name == armorName);
            if (armor != null)
            {
                Armors.Add(armor);
                Console.WriteLine($"{armor.Name,24} added to inventory.");
            }
            else
            {
                Console.WriteLine("Armor not found");
            }
        }
        public void AddWeapon(string weaponName)
        {
            Weapon weapon = Weapon.AllWeapons.Find(a => a.Name == weaponName);

            if (weapon != null)
            {
                Weapons.Add(weapon);
                Console.WriteLine($"{weapon.Name,24} added to inventory.");
            }
            else
            {
                Console.WriteLine("Armor not found");
            }
        }
        public void SetCurrentArmor(string armorName)
        {
            Armor selectedArmor = Armors.Find(a => a.Name.Equals(armorName, StringComparison.OrdinalIgnoreCase));
            if (selectedArmor != null)
            {
                CurrentArmor = selectedArmor;
                Console.WriteLine($"{selectedArmor.Name} is now your equipped armor.");
                Console.WriteLine();
                Console.WriteLine("/Press any Key/");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Armor not found in your inventory!");
                Console.WriteLine();
                Console.WriteLine("/Press any Key/");
                Console.ReadKey();
                Console.Clear();

            }
        }
        public void SetCurrentWeapon(string weaponName, Player p)
        {
            Weapon selectedWeapon = Weapons.Find(a => a.Name.Equals(weaponName, StringComparison.OrdinalIgnoreCase));
            if (selectedWeapon != null)
            {
                CurrentWeapon = selectedWeapon;
                Console.WriteLine($"{selectedWeapon.Name} is now your equipped weapon.");
                Console.WriteLine();
                Console.WriteLine("/Press any Key/");
                Console.ReadKey();
                Console.Clear();
                p.weaponValue = CurrentWeapon.Attack;
            }
            else
            {
                Console.WriteLine("Weapon not found in your inventory!");
                Console.WriteLine();
                Console.WriteLine("/Press any Key/");
                Console.ReadKey();
                Console.Clear();

            }
        }
        public void BasicInventory(Player p)
        {
            Armors.Add(new Armor("Linen Tunic", 0, 0));
            Weapons.Add(new Weapon("Long Stick", 2, 0));
            SetCurrentArmor("Linen Tunic");
            SetCurrentWeapon("Long Stick", p);
        }
        public void ShowInventory(Player p)
        {
            while (true)
            {
                Console.WriteLine("                 Inventory                 ");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|    (A)rmors             (W)eapons       |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                                         |");
                Console.WriteLine("|                (E)xit                   |");
                Console.WriteLine("|                                         |");
                Console.WriteLine(" ----------------------------------------- ");
                Console.WriteLine("");
                string input = Console.ReadLine().ToLower();
                if (input == "a" || input == "armors")
                {
                    Console.Clear();
                    Console.WriteLine("                   Armors                  ");
                    Console.WriteLine(" ----------------------------------------- ");
                    Console.WriteLine("|                                         |");
                    foreach (var armor in Armors)
                    {
                        Shop.ShowArmorInfo(armor);
                        Console.WriteLine("|.........................................|");
                    }
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|         (E)xit          (P)ick          |");
                    Console.WriteLine(" -----------------------------------------");

                    string choice = Console.ReadLine().ToLower();
                    if (choice == "p" || choice == "pick")
                    {
                        Console.WriteLine("Name of chosen armor: ");
                        string pick = Console.ReadLine().ToLower();
                        SetCurrentArmor(pick);
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                else if (input == "w" || input == "weapons")
                {
                    Console.Clear();
                    Console.WriteLine("                  Weapons                  ");
                    Console.WriteLine(" ----------------------------------------- ");
                    Console.WriteLine("|                                         |");
                    foreach (var weapon in Weapons)
                    {
                        Shop.ShowWeaponInfo(weapon);
                        Console.WriteLine("|.........................................|");
                    }
                    Console.WriteLine("|                                         |");
                    Console.WriteLine("|         (E)xit          (P)ick          |");
                    Console.WriteLine(" ----------------------------------------- ");

                    string choice = Console.ReadLine().ToLower();
                    if (choice == "p" || choice == "pick")
                    {
                        Console.WriteLine("Name of chosen weapon: ");
                        string pick = Console.ReadLine().ToLower();
                        SetCurrentWeapon(pick,p);
                        Console.ReadKey();
                    }
                }
                else if (input == "e" || input == "exit")
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
            }
        }


        //Difficulty Method
        public int GetDef()
        {
            if (rand == null)
            {
                throw new InvalidOperationException("Random generator has not been initialized.");
            }

            int upper = 2 * mods + 6;
            int lower = mods + 2;
            if (lower >= upper)
            {
                throw new ArgumentOutOfRangeException("lower");
            }
            return rand.Next(lower, upper);
        }
        public int GetAttack()
        {
            if (rand == null)
            {
                throw new InvalidOperationException("Random generator has not been initialized.");
            }

            int upper = 2 * mods + 2;
            int lower = mods + 2;
            if (lower >= upper)
            {
                throw new ArgumentOutOfRangeException("lower");
            }
            return rand.Next(lower, upper);
        }
    }
}
