using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Fleet
    {
        //variabes (HAS A)
        public Robot wallE;
        //public Robot Sonny;
        //public Robot bayMax;

        //constructor (Spawner)
        public Fleet()
        {
            wallE = new Robot("WallE");
        }

        //methods (CAN DO)
        public void AttackDinos()
        {
            wallE.AttackDino();
        }
        public void LoseHealthPoints()
        {
            wallE.LoseHealth();
        }

    }
}
