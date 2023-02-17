using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Characters
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base(name)
        {
           
            ValidWeaponTypes = new List<WeaponTypes>() { WeaponTypes.Daggers, WeaponTypes.Swords };
            ValidArmorTypes = new List<ArmorTypes>() { ArmorTypes.Leather, ArmorTypes.Mail };
            LevelAttributes.Strength = 2;
            LevelAttributes.Dexterity = 6;
            LevelAttributes.Intelligence = 1;
            DamagingAttribute = LevelAttributes.Dexterity;
        }
        public override void Levelup()
        {
            
            Level++;
            HeroAttribute attributeIncrease = new HeroAttribute(1, 4, 1);
            LevelAttributes = LevelAttributes.IncreaseBy(attributeIncrease);
        }

        public override void Equip(Item item)
        {
            if (item is Weapon)
            {
                if (!ValidWeaponTypes.Contains((item as Weapon).WeaponType))
                {
                    Console.WriteLine("This weapon is invalid for Mage");
                    return;
                }
                else if (!ValidArmorTypes.Contains((item as Armor).ArmorType))
                {
                    Console.WriteLine("This armor is invalid for Mage");
                    return;
                }
            }
            Equipment[item.Slot] = item;
        }

        public override int CalculateDamage()
        {
            int damagge = LevelAttributes.Dexterity * 4;
            if (Equipment[Slots.Weapon] != null && Equipment[Slots.Weapon] is Weapon)
            {
                damagge += (Equipment[Slots.Weapon] as Weapon).Damage;
            }
            return damagge;
        }
    }
}
