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
            ValidWeaponTypes = new List<WeaponTypes>() { WeaponTypes.Staffs, WeaponTypes.Staffs };
            ValidArmorTypes = new List<ArmorTypes>() { ArmorTypes.Cloth };
            LevelAttributes.Strength = 1;
            LevelAttributes.Dexterity = 1;
            LevelAttributes.Intelligence = 8;
            DamagingAttribute = LevelAttributes.Intelligence;
        }

        public override void Levelup()
        {
           
            Level ++;
            HeroAttribute attributeIncrease = new HeroAttribute(1, 1, 5);
            LevelAttributes = LevelAttributes.IncreaseBy(attributeIncrease);
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
                else if(item is Armor)
                {
                    if (!ValidArmorTypes.Contains((item as Armor).ArmorType))
                    {
                        Console.WriteLine("This armor is invalid for Mage");
                        return;
                    }
                }
            }
            Equipment[item.Slot] = item;
        }

        public override int CalculateDamage()
        {

            int damagge = LevelAttributes.Intelligence * 2;
            if (Equipment[Slots.Weapon] != null && Equipment[Slots.Weapon] is Weapon)
            {
                damagge += (Equipment[Slots.Weapon] as Weapon).Damage;
            }
            return damagge;

        }

    }
}
