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
        public int healthRobot;
        public int powerLevel;
        public int attackPower;
        public Weapon robotWeapon;



        //constructors (SPAWNER)
        public Robot(string name)
        {

            this.name = name;
            attackPower = 10;
            healthRobot = 100;
            powerLevel = 100;
            PickUpWeapon();
            Console.WriteLine("You have spawn " + name + " for your fleet.");
            Console.WriteLine(name + " has stats of " + attackPower + " attack power, " + healthRobot + " health and " + powerLevel + " power level.");
            Console.ReadLine();
        }

        //member methods (CAN DO)
        public void PickUpWeapon()
        {
            robotWeapon = new Weapon("Gun");
        }
        public void AttackDino(Dino dino)
        {
            if (powerLevel >= 1 && healthRobot >= 1)
            {
                powerLevel -= 10;
                robotWeapon.useWeapon();
                dino.healthDino -= attackPower;
                Console.WriteLine(name + " used " + robotWeapon.typeWeapon + " to attack " + dino.typeOfDino + ".");
                Console.WriteLine(dino.typeOfDino + " loss " + attackPower + " health.");
                Console.WriteLine(name + " has " + attackPower + " attack power.");
                Console.WriteLine(name + " has " + powerLevel + " power level.");
                Console.WriteLine(name + " has " + healthRobot + " health.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine(name + " is out of power and/or health and cannot attack.");
                Console.ReadLine();
            }
            
        }
        public void LoseHealth()
        {
            if (healthRobot >= 1)
            {
                healthRobot -= 10;
            }
            else if (healthRobot >= 0)
            { 
                Console.WriteLine(name + " has lost all health!");
                Console.ReadLine();
            }
        }
    }
}
