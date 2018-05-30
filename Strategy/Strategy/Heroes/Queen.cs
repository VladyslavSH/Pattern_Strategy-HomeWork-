using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    public class Queen : Character
    {
        public override void Display()
        {
            Console.WriteLine("I`m Queen ");
        }
        public Queen()
        {
            Icharacter = new Fight();
            Iweapon = new KnifeBehavior();
        }
    }
}
