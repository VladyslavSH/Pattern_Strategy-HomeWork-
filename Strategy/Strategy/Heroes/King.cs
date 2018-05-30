using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    public class King : Character
    {
        public override void Display()
        {
            Console.WriteLine("I`m King!");
        }
        public King()
        {
            Icharacter = new Fight();
            Iweapon = new SwordBehavior();
        }
    }
}
