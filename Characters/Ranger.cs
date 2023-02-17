using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Characters
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            ValidWeaponTypes = new List<WeaponTypes>() { WeaponTypes.Bows };
            ValidArmorTypes = new List<ArmorTypes>() { ArmorTypes.Leather, ArmorTypes.Mail };
            LevelAttributes.Strength = 1;
            LevelAttributes.Dexterity = 7;
            LevelAttributes.Intelligence = 1;
            DamagingAttribute = LevelAttributes.Dexterity;


        }

        public override void Levelup()
        {
            
            Level++;
            HeroAttribute attributeIncrease = new HeroAttribute(1, 5, 1);
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
            int damagge = LevelAttributes.Dexterity * 5;
            if (Equipment[Slots.Weapon] != null && Equipment[Slots.Weapon] is Weapon)
            {
                damagge += (Equipment[Slots.Weapon] as Weapon).Damage;
            }
            return damagge;
        }
    }
}
