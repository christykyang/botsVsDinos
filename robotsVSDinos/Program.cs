using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Program
    {
        static void Main(string[] args)
        {
            weapon sword = new weapon("Sword");

            Console.WriteLine(sword.typeWeapon);
            Console.WriteLine(sword.weaponDurability);
            Console.WriteLine(sword.attackPower);

            sword.useWeapon();

            Console.WriteLine(sword.typeWeapon);
            Console.WriteLine(sword.weaponDurability);
            Console.WriteLine(sword.attackPower);

            Console.ReadLine();


        }
    }
}
