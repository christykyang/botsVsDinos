using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Heard
    {
        //variables (HAS A)
        public Dino tRex;
        //public Dino raptor;
        //public Dino triCeratops;

        //constructors (Spawner)
        public Heard()
        {
            tRex = new Dino("T-Rex", 10);
        }

        //methods (CAN DO)
        public void AttackRobots()
        {
            tRex.AttackRobot();
        }
        public void LoseHealth()
        {
            tRex.LoseHealth();
        }
    }
}
