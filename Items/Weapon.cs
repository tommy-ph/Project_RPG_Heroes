using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Items
{
    public class Weapon: Item
    {
        public WeaponTypes WeaponType { get; set; }
        public int WeaponDamage { get; set; }

        public Weapon(string nameItem, int requiredLevelItem,Slots slotItem, WeaponTypes weaponType, int weaponDamage) : base(nameItem, requiredLevelItem,slotItem)
        {
            WeaponType= weaponType;
            WeaponDamage= weaponDamage;

        }
    }
}
