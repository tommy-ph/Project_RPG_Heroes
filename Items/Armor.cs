using Project_RPG_Heroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Items
{
    public class Armor: Item
    {
        
        public ArmorTypes ArmorType { get; set; }
        public HeroAttribute ArmorAttribute { get; set; }

        public Armor(string nameItem, int requiredLevelItem, Slots slotItem, ArmorTypes armorType, HeroAttribute armorAttribute) : base(nameItem, requiredLevelItem, slotItem)
        {
            NameItem= nameItem;
            RequiredLevelItem= requiredLevelItem;
            SlotItem= slotItem;
            ArmorType= armorType;
            ArmorAttribute= armorAttribute;
        }


    }
}
