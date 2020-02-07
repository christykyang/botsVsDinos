using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class dino
    {
        //member variables (HAS A)
        public string typeOfDino;
        public int healthDinoFull;
        public string attackPower;
        public int energyLevel;

        //constructors (SPAWNER)
        public dino(string typeOfDino)
        {
            this.typeOfDino = typeOfDino;
            healthDinoFull = 100;
            attackPower = "Head Butt";
            energyLevel = 4;

        }

        //member methods (CAN DO)
        public void attackRobot()
        {
            energyLevel -= 1;
        }
    }
}
