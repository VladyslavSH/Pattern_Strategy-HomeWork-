using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Heroes
{
    public class Fight : ICharacter
    {
        public void fight()
        {
            Console.Write("I fight with ");
        }
    }
}
