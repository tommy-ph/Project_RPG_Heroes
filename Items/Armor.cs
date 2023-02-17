using Project_RPG_Heroes.Attributes;
using Project_RPG_Heroes.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_RPG_Heroes.Items
{
    public class Armor: Item
    {
        
        public ArmorTypes ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(string name, int requiredLevel, Slots slot, ArmorTypes armorType, HeroAttribute armorAttribute) : base(name, requiredLevel, slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            ArmorType = armorType;
            ArmorAttribute = armorAttribute;
        }

        public override void Equip(Hero hero)
        {
            throw new NotImplementedException();
        }
    }
}
