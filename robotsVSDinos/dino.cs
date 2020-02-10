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
        public int healthDino;
        public int attackPower;
        public int energyLevel;

        //constructors (SPAWNER)
        public Dino(string typeOfDino)
        {
            this.typeOfDino = typeOfDino;
            attackPower = 10;
            healthDino = 100;
            energyLevel = 5;
            Console.WriteLine("You have spawn " + typeOfDino + " for your herd.");
            Console.WriteLine(typeOfDino + " has " + attackPower + " attack power " + healthDino + " health and " + energyLevel + " energy level.");
            Console.ReadLine();
        }

        //member methods (CAN DO)
        public void AttackRobot(Robot robot)
        {
            if (energyLevel >= 1)
            {
                energyLevel -= 1;
            }
            else if (energyLevel >= 0)
            {
                Console.WriteLine("This Dino is out of energy and cannot attack!");
            }

        }
        public void LoseHealth()
        {
            if (healthDino >= 1)
            {
                healthDino -= 10;
            }
            else if (healthDino >= 0)
            {
                Console.WriteLine("This Dino has lost all health!");
            }
        }
    }
}
