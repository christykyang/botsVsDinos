using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Robot
    {

        //member variables (HAS A)
        public string name;
        public int healthFull;
        public int powerLevel;
        public int attackPower;
        public Weapon robotWeapon;



        //constructors (SPAWNER)
        public Robot(string name)
        {
            this.name = name;
            attackPower = 10;
            healthFull = 100;
            powerLevel = 10;
            PickUpWeapon();
        }

        //member methods (CAN DO)
        public void PickUpWeapon()
        {
            robotWeapon = new Weapon("Gun");
        }
        public void AttackDino()
        {
            powerLevel -= 1;
            robotWeapon.useWeapon();
        }
        public void LoseHealth()
        {
            healthFull -= 10;
        }
    }
}
