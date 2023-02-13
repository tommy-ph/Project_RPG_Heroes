using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Characters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slots,Item> Equipment { get; set; } 
        public List<WeaponTypes> ValidWeaponTypes { get; set; } 
        public List<ArmorTypes> ValidArmorTypes { get; set; }
        //public HeroAttribute heroAttributes;

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(0, 0, 0);
            Equipment = new Dictionary<Slots, Item>
            {
                {Slots.Head, null},
                {Slots.Body, null},
                {Slots.Legs, null },
                {Slots.Weapon, null}
            };
            ValidWeaponTypes = new List<WeaponTypes>();
            ValidArmorTypes = new List<ArmorTypes>();
           // heroAttributes = new HeroAttribute();
        }

        public abstract void Levelup();

        public  virtual void Equip(Item item)
        {
            if(item is Weapon && ValidWeaponTypes.Contains((item as Weapon).WeaponType))
            {
                Equipment[Slots.Weapon] = item;
            }
            else if(item is Armor && ValidArmorTypes.Contains((item as Armor).ArmorType))
            {
                Equipment[item.SlotItem] = item; 
            }
        }

        public virtual int Damage()
        {
            int damage = 0;
            if (Equipment[Slots.Weapon] != null)
            {
                Weapon weapon = (Weapon)Equipment[Slots.Weapon];
                damage += weapon.WeaponDamage;
            }
            return damage;
        }
        public virtual HeroAttribute TotalAttributes()
        {
            HeroAttribute totalAttributes = LevelAttributes;

            if (Equipment[Slots.Head] is Armor head)
            {
                totalAttributes += head.ArmorAttribute;
            }

            if (Equipment[Slots.Body] is Armor body)
            {
                totalAttributes += body.ArmorAttribute;
            }

            if (Equipment[Slots.Legs] is Armor legs)
            {
                totalAttributes += legs.ArmorAttribute;
            }

            return totalAttributes;
        }
        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Level attributes: ");
            Console.WriteLine($"Strength: {LevelAttributes.Strength}");
            Console.WriteLine($"Dexterity: {LevelAttributes.Dexterity}");
            Console.WriteLine($"Intelligence: {LevelAttributes.Intelligence}");
            Console.WriteLine($"Equipment:");

            foreach(var item in Equipment)
            {
                Console.WriteLine($"{item.Key}: {item.Value?.NameItem ?? "None"}");
            }
        }
    }
}
