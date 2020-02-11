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
            Console.WriteLine("Welcome to Robots VS. Dinosaurs!");
            Console.ReadLine();
            Console.WriteLine("Lets play!");
            Console.ReadLine();
            Console.WriteLine("We will create your fleet first!");
            Console.ReadLine();
            bots = new Fleet();
            Console.WriteLine("Now that your fleet is complete we shall create your herd!");
            Console.ReadLine();
            dinos = new Herd();
            Console.WriteLine("Game start!");
            Console.ReadLine();
        }

        //methods (CAN DO)
        //public int WhoGoesFirst(Random rnd)
        //{
        //    int result;


        //    result = rnd.Next(1, 2);
        //    Console.WriteLine(result);
        //    return result;
        //}
        //public void CompareWhoGoesFirst(int bots, int dinos)
        //{
        //    if (bots < dinos)
        //    {
        //        AttackRobots();
        //        Console.WriteLine("Dinos attack first!");
        //    }
        //    else if (bots > dinos)
        //    {
        //        AttackDinos();
        //        Console.WriteLine("Robots attack first!");
        //    }
        //}

        public void AttackDinos()
        {
            bots.robotList[0].AttackDino(dinos.dinoList[0]);
            dinos.dinoList[0].LoseHealth();
            bots.robotList[1].AttackDino(dinos.dinoList[1]);
            dinos.dinoList[1].LoseHealth();
            bots.robotList[2].AttackDino(dinos.dinoList[2]);
            dinos.dinoList[2].LoseHealth();
        }
        public void AttackRobots()
        {
            dinos.dinoList[0].AttackRobot(bots.robotList[0]);
            bots.robotList[0].LoseHealth();
            dinos.dinoList[1].AttackRobot(bots.robotList[1]);
            bots.robotList[1].LoseHealth();
            dinos.dinoList[2].AttackRobot(bots.robotList[2]);
            bots.robotList[2].LoseHealth();

        }
  




        public void RunGame()
        {
            
            while (bots.GetHealthOfFleet() >= 1 && dinos.GetHealthOfHerd() >= 1)
            {
                AttackDinos();
                AttackRobots();

            }
            if (dinos.GetHealthOfHerd() == 0)
            {
                dinos.DinosLoseGame();
            }
            else if (bots.GetHealthOfFleet() == 0)
            {
                bots.BotsLoseGame();
            }
        }


    }
}
