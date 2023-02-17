using Project_RPG_Heroes.Characters;
using Project_RPG_Heroes.Exceptions;
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
        public int Damage { get; set; }

        public Weapon(string name, int requiredLevel,Slots slot, WeaponTypes weaponType, int damage) : base(name, requiredLevel,slot)
        {
            WeaponType= weaponType;
            Damage= damage;
        }

        public override void Equip(Hero hero)
        {
            if(!hero.ValidWeaponTypes.Contains(WeaponType))
            {
                throw new InvalidWeaponException($"Cannot equip {Name} because it is not a valid armor for {hero.GetType().Name}.");
            }

            if(hero.Level < RequiredLevel)
            {
                throw new InvalidWeaponException($"Cannot equip {Name} because it requires level {RequiredLevel} and {hero.Name} is only level {hero.Level}.");
            }
            hero.Equipment[Slot] = this;
        }
    }
}
