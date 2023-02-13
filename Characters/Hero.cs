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

        public Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(0, 0, 0);
            Equipment = new Dictionary<Slots, Item>
            {
                {Slots.Head, null},
                {Slots.Body, null },
                {Slots.Legs, null },
                {Slots.Weapon, null }
            };
            ValidWeaponTypes = new List<WeaponTypes>();
            ValidArmorTypes = new List<ArmorTypes>();
        }
    }
}
