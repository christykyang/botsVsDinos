﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class weapon
    {
        //member variables (HAS A)
        public string typeWeapon;
        public int weaponDurability;
        public int attackPower;

        //constructors (SPAWNER)
        public weapon(string typeWeapon)
        {
            this.typeWeapon = typeWeapon;
            weaponDurability = 5;
            attackPower = 0;
        }

        //member methods (CAN DO)
        //public void attack()
        //{
        //    attackPower = +10;
        //}
        //public void durability()
        //{
        //    weaponDurability -= 1;
        //}

        public void useWeapon()
        {
            attackPower += 10;
            weaponDurability -= 1;
        }
        
    }
}