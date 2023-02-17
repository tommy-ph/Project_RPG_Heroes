using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Characters;
using Project_RPG_Heroes.Items;
using System;

namespace Project_RPG_Heroes
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Create hero objects with weapons and armor
            Mage mage1 = new Mage("Mage");
            mage1.Equip(new Weapon("Mage's weapon", 1, Slots.Weapon, WeaponTypes.Staffs ,20));
            mage1.Equip(new Armor("Armor", 2, Slots.Armor, ArmorTypes.Cloth, new HeroAttribute(1, 1, 5)));

            Ranger ranger1 = new Ranger("Ranger");
            ranger1.Equip(new Weapon("Ranger's weapom", 1, Slots.Weapon, WeaponTypes.Staffs, 20));
            ranger1.Equip(new Armor("Armor", 2, Slots.Armor, ArmorTypes.Cloth, new HeroAttribute(5, 5, 5)));

            Rogue rogue1 = new Rogue("Rogue");
            rogue1.Equip(new Weapon("Rogue's weapon", 1, Slots.Weapon, WeaponTypes.Staffs, 20));
            rogue1.Equip(new Armor("Armor", 2, Slots.Armor, ArmorTypes.Cloth, new HeroAttribute(5, 5, 5)));

            Warrior warrior1 = new Warrior("Warrior");
            warrior1.Equip(new Weapon("Warrior's weapon", 1, Slots.Weapon, WeaponTypes.Staffs, 20));
            warrior1.Equip(new Armor("Armor", 2, Slots.Armor, ArmorTypes.Cloth, new HeroAttribute(5, 5, 5)));

            // Display hero information
            Console.WriteLine(mage1.Display());
            Console.WriteLine(ranger1.Display());
            Console.WriteLine(rogue1.Display());
            Console.WriteLine(warrior1.Display());

            // Level up heroes and calculate damage
            mage1.Levelup();
            ranger1.Levelup();
            rogue1.Levelup();
            warrior1.Levelup();

            int damageGandalf = mage1.CalculateDamage();
            int damageRanger = ranger1.CalculateDamage();
            int damageRogue = rogue1.CalculateDamage();
            int damageWarrior = warrior1.CalculateDamage();

            // Display new hero information and damage
            Console.WriteLine(mage1.Display());
            Console.WriteLine(ranger1.Display());
            Console.WriteLine(rogue1.Display());
            Console.WriteLine(warrior1.Display());


        }
    }
}