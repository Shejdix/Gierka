using Gierka.Armory;
using Gierka.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public string name;
        public int runes = 100;
        public int health = 10;
        public int damage = 1;
        public int weaponValue = 1;
        public int defence = 0;
        public int blessings = 5;

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
        public void SetCurrentWeapon(string weaponName)
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
        public void BasicInventory()
        {
            Armors.Add(new Armor("Linen Tunic", 0, 0));
            Weapons.Add(new Weapon("Long Stick", 2, 0));
            SetCurrentArmor("Linen Tunic");
            SetCurrentWeapon("Long Stick");
        }
        public void ShowInventory()
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
                    Console.WriteLine("|                                        |");
                    foreach (var armor in Armors)
                    {
                        Shop.ShowArmorInfo(armor);
                        Console.WriteLine("|........................................|");
                    }
                    Console.WriteLine("|                                        |");
                    Console.WriteLine("|         (E)xit          (P)ick         |");
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
                        SetCurrentWeapon(pick);
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
            int upper = 2 * mods + 6;
            int lower = mods + 2;
            return rand.Next(lower, upper);
        }
        public int GetAttack()
        {
            int upper = 2 * mods + 2;
            int lower = mods + 2;
            return rand.Next(lower, upper);
        }
    }
}
