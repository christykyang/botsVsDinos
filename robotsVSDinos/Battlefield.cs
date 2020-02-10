using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Battlefield
    {
        
        //variables (HAS A)
        public Fleet bots;
        public Herd dinos;

 

        //constructors (spawner)
        public Battlefield()
        {
            bots = new Fleet();
            dinos = new Herd();
            
        }

        //methods (CAN DO)
        public int WhoGoesFirst(Random rnd)
        {
            int result;


            result = rnd.Next(1, 2);
            Console.WriteLine(result);
            return result;
        }
        public void CompareWhoGoesFirst(int bots, int dinos)
        {
            if (bots < dinos)
            {
                AttackRobots();
                Console.WriteLine("Dinos attack first!");
            }
            else if (bots > dinos)
            {
                AttackDinos();
                Console.WriteLine("Robots attack first!");
            }
        }

        public void AttackDinos()
        {
            bots.robotList[0].AttackDino(dinos.dinoList[0]);
            bots.robotList[1].AttackDino(dinos.dinoList[1]);
            bots.robotList[2].AttackDino(dinos.dinoList[2]);
        }
        public void AttackRobots()
        {
            dinos.dinoList[0].AttackRobot(bots.robotList[0]);
            dinos.dinoList[1].AttackRobot(bots.robotList[1]);
            dinos.dinoList[2].AttackRobot(bots.robotList[2]);
        }
        public void DisplayWinner()
        {
            if (bots.robotList[0].healthRobot >= 0 && bots.robotList[1].healthRobot >= 0 && bots.robotList[2].healthRobot >= 0)
            {
                Console.WriteLine("Dinos win!");
            }
            else if (dinos.dinoList[0].healthDino >= 0 && dinos.dinoList[1].healthDino >= 0 && dinos.dinoList[2].healthDino >= 0)
            {
                Console.WriteLine("Robots win!");
            }
        }

        


        public void RunGame()
        {

        }


    }
}
