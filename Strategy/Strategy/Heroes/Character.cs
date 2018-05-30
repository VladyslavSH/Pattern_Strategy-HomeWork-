using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    public abstract class Character
    {
       public ICharacter Icharacter;
        public IWeaponBehavior Iweapon;

        public abstract void Display();

        public void PerformFight()
        {
            Icharacter.fight();
        }

        public void PerformWeapon()
        {
            Iweapon.UseWeapon();
        }
    }
}
