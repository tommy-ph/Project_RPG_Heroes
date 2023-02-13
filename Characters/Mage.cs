using Project_RPG_Heroes.Attributes;
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
            ValidWeaponTypes.Add(WeaponTypes.Staffs);
            ValidWeaponTypes.Add(WeaponTypes.Wands);
            ValidArmorTypes.Add(ArmorTypes.Cloth);
            LevelAttributes.Intelligence = 10;
        }
    }
}
