using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Items
{
    public abstract class Item
    {
        public string NameItem { get; set; }
        public int RequiredLevelItem { get; set; }
        public Slots SlotItem { get; set; }

        public Item(string nameItem, int requiredLevelItem, Slots slotItem)
        {
            NameItem = nameItem;
            RequiredLevelItem = requiredLevelItem;
            SlotItem = slotItem;
        }
    }
}
