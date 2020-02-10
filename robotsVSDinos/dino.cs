using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Dino
    {
        //member variables (HAS A)
        public string typeOfDino;
        public int healthDinoFull;
        public int attackPower;
        public int energyLevel;

        //constructors (SPAWNER)
        public Dino(string typeOfDino, int attackPower)
        {
            this.typeOfDino = typeOfDino;
            this.attackPower = attackPower;
            healthDinoFull = 100;
            energyLevel = 5;

        }

        //member methods (CAN DO)
        public void AttackRobot()
        {
            energyLevel -= 1;

        }
        public void LoseHealth()
        {
            healthDinoFull -= 10;
        }
    }
}
