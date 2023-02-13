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
            ValidWeaponTypes.Add(WeaponTypes.Daggers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
            ValidArmorTypes.Add(ArmorTypes.Leather);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }
    }
}
