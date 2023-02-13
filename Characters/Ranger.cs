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
            ValidWeaponTypes.Add(WeaponTypes.Bows);
            ValidArmorTypes.Add(ArmorTypes.Leather);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }
    }
}
