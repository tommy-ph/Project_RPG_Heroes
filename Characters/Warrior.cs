using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_RPG_Heroes.Characters
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            ValidWeaponTypes.Add(WeaponTypes.Axes);
            ValidWeaponTypes.Add(WeaponTypes.Hammers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
            ValidArmorTypes.Add(ArmorTypes.Mail);
            ValidArmorTypes.Add(ArmorTypes.Plate);
        }
    }
}
