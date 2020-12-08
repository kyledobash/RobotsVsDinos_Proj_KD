using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Battlefield
    {
        //MEMBER VARIABLES (what it has)
        // HAS a fleet and a herd
        public int roundCounter;
        public Herd fightingHerd;
        public Fleet fightingFleet;

        //CONSTRUCTOR (spawner)
        public Battlefield()
        {
            this.roundCounter = 0;
            this.fightingFleet = new Fleet();
            this.fightingHerd = new Herd();
        }

        //MEMBER METHODS (what can it do)
        public void ExecuteGameFlow()
        {
            int deadRobots = 0;
            int deadDinos = 0;

            while (deadDinos < 3 && deadRobots < 3)
            {                
                Random rnd = new Random();
                int attackerSelect = rnd.Next(0, 2);
                int victimSelect = rnd.Next(0, 2);

                foreach (Robot currentRobot in fightingFleet.robotFleet)
                {
                    if (currentRobot.health <= 0)
                    {
                        deadRobots++;
                    }
                }
                foreach (Dinosaur currentDinosaur in fightingHerd.dinosaurHerd)
                {
                    if (currentDinosaur.health <= 0)
                    {
                        deadDinos++;
                    }
                }

                fightingHerd.dinosaurHerd[attackerSelect].DinoAttack(fightingFleet.robotFleet[victimSelect]);
                fightingFleet.robotFleet[attackerSelect].RoboAttack(fightingHerd.dinosaurHerd[victimSelect]);

                roundCounter++;
            }
            if (deadDinos == 3)
            {
                Console.WriteLine("The Robots have defeated the Dinosaurs!!");
                Console.ReadLine();
            }
            else if(deadRobots == 3)
            {
                Console.WriteLine("The Dinosaurs have defeated the Robots!!");
                Console.ReadLine();
            }
        }
    }
}
