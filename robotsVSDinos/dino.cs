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
            energyLevel = 100;
            Console.WriteLine("You have spawn " + typeOfDino + " for your herd.");
            Console.WriteLine(typeOfDino + " has " + attackPower + " attack power " + healthDino + " health and " + energyLevel + " energy level.");
            Console.ReadLine();
        }

        //member methods (CAN DO)
        public void AttackRobot(Robot robot)
        {
            if (energyLevel >= 1 && healthDino >= 1)
            {
                energyLevel -= 1;
                robot.healthRobot -= attackPower;
                Console.WriteLine(typeOfDino + " attacked " + robot.name + ".");
                Console.WriteLine(robot.name + " loss " + attackPower + " health.");
                Console.WriteLine(typeOfDino + " has " + attackPower + " attack power.");
                Console.WriteLine(typeOfDino + " has " + energyLevel + " energy level.");
                Console.WriteLine(typeOfDino + " has " + healthDino + " health.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("This " + typeOfDino + " is out of energy and/or health and cannot attack!");
                Console.ReadLine();
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
                Console.WriteLine("This " + typeOfDino + " has lost all health!");
                Console.ReadLine();
            }
        }
    }
}
