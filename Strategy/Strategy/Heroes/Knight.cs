using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    class Knight : Character
    {
        public override void Display()
        {
            Console.WriteLine("I`m Knight ");
        }
        public Knight()
        {
            Icharacter = new Fight();
            Iweapon = new BowAndArrowBehavior();
        }
    }
}
