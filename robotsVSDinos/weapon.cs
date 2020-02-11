using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Weapon
    {
        //member variables (HAS A)
        public string typeWeapon;
        public int weaponDurability;
        public int attackPower;

        //constructors (SPAWNER)
        public Weapon(string typeWeapon)
        {
            this.typeWeapon = typeWeapon;
            weaponDurability = 5;
            attackPower = 0;
        }

        //member methods(CAN DO)

        public void useWeapon()
        {
            if (weaponDurability > 0)
            {
                attackPower += 10;
                weaponDurability -= 1;
            }
            else if (weaponDurability >= 0)
            {
                Console.WriteLine("Weapon broke, please sue different weapon.");
            }
   
        }

    }
}
