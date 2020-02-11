using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVSDinos
{
    class Herd
    {
        //variables (HAS A)
        //public Dino tRex;
        //public Dino raptor;
        //public Dino triCeratops;
        public List<Dino> dinoList;

        //constructors (Spawner)
        public Herd()
        {
            dinoList = new List<Dino>();
            Dino tRex = new Dino("T-Rex");
            dinoList.Add(tRex);
            Dino raptor = new Dino("Raptor");
            dinoList.Add(raptor);
            Dino triCeratops = new Dino("Triceratops");
            dinoList.Add(triCeratops);
            Console.WriteLine("Your herd is complete!");
            Console.ReadLine();
        }

        //methods (CAN DO)
        public void DinosLoseGame()
        {
            if (dinoList[0].healthDino == 0 && dinoList[1].healthDino == 0 && dinoList[2].healthDino == 0);
            {
                Console.WriteLine("Robots win!");
                Console.ReadLine();

            }
            
        }
        public int GetHealthOfHerd()
        {
            int healthOfAllDinos;
            healthOfAllDinos = dinoList[0].healthDino + dinoList[1].healthDino + dinoList[2].healthDino;
            return healthOfAllDinos;
        }

    }
}
