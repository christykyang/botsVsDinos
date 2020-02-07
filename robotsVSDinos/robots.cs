using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class robot
    {
        
        //member variables (HAS A)
        public string name;
        public int healthFull;
        public int powerLevel;
        public string attackPower;
        public string robotWeapon;
        
        


        //constructors (SPAWNER)
        public robot()
        {
            name = "Donny";
            healthFull = 100;
            powerLevel = 10;
            attackPower = "Cut";
            robotWeapon = "Sword";

        }

        //member methods (CAN DO)
        public void attackDino()
        {
            powerLevel -= 1;
        }
    }
}
