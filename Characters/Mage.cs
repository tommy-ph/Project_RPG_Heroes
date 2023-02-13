using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Characters
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            ValidWeaponTypes.Add(WeaponTypes.Staffs);
            ValidWeaponTypes.Add(WeaponTypes.Wands);
            ValidArmorTypes.Add(ArmorTypes.Cloth);
            LevelAttributes.Intelligence = 10;
        }

        public override void Levelup()
        {
            Level++;
            LevelAttributes.Intelligence += 5;
        }

        public override void Equip(Item item)
        {
            if(item is Weapon)
            {
                if(!ValidWeaponTypes.Contains((item as Weapon).WeaponType))
                {
                    Console.WriteLine("This weapon is invalid for Mage");
                    return;
                }
                else if(!ValidArmorTypes.Contains((item as Armor).ArmorType))
                {
                    Console.WriteLine("This armor is invalid for Mage");
                    return;
                }
            }
            Equipment[item.SlotItem] = item;
        }

        public override int Damage()
        {
            int damagge = LevelAttributes.Intelligence * 2;
            if (Equipment[Slots.Weapon] != null)
            {
                damagge += (Equipment[Slots.Weapon] as Weapon).WeaponDamage;
            }
            return damagge;
        }

        public override HeroAttribute TotalAttributes()
        {
            HeroAttribute totalAttributes = LevelAttributes;
            foreach(var item in Equipment.Values)
            {
                if(item != null && item is Armor)
                {
                    totalAttributes += (item as Armor).ArmorAttribute;
                }
            }
            return totalAttributes;
        }

        public override void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Level: " + Level);
            Console.WriteLine("Intelligence: " + LevelAttributes.Intelligence);
            Console.WriteLine("Equipment:");
            foreach (var item in Equipment)
            {
                if (item.Value != null)
                {
                    Console.WriteLine("- " + item.Value.NameItem + " (" + item.Key + ")");
                }
            }
        }

    }
}
