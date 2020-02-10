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
        
        //public Robot Sonny;
        //public Robot bayMax;
        public List<Robot> robotList;

        //constructor (Spawner)
        public Fleet()
        {
            robotList = new List<Robot>();
            Robot wallE = new Robot("WallE");
            robotList.Add(wallE);
            Robot sonny = new Robot("Sonny");
            robotList.Add(sonny);
            Robot bayMax = new Robot("Baymax");
            robotList.Add(bayMax);
            Console.WriteLine("Your fleet is complete!");
            Console.ReadLine();
        }

        //methods (CAN DO)
        

        public void BotsLoseGame()
        {
            
            
        }

    }
    }
        
    
