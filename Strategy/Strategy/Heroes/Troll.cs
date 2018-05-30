using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    public class Troll : Character
    {
        public override void Display()
        {
            Console.WriteLine("I`m Troll ");
        }
        public Troll()
        {
            Icharacter = new Fight();
            Iweapon = new AxeBehavior();
        }
    }
}
