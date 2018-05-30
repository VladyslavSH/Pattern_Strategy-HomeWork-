using Strategy.Heroes;
using Strategy.WeaponB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.AddRange(new Character[]
            {
                new King(),
                new Knight(),
                new Queen(),
                new Troll()
            });
            foreach (Character item in characters)
            {
                item.Display();
                item.PerformFight();
                item.PerformWeapon();
                Console.WriteLine("==================");
            }
        }
    }
}
