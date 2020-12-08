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

                int dinoSelect = rnd.Next(0, (fightingHerd.dinosaurHerd.Count() - 1));
                int roboSelect = rnd.Next(0, (fightingFleet.robotFleet.Count() - 1));

                foreach (Robot currentRobot in fightingFleet.robotFleet)
                {
                    if (currentRobot.health <= 0)
                    {
                        fightingFleet.robotFleet.Remove(currentRobot);
                        deadRobots++;
                        break;
                    }
                }

                foreach (Dinosaur currentDinosaur in fightingHerd.dinosaurHerd)
                {
                    if (currentDinosaur.health <= 0)
                    {
                        fightingHerd.dinosaurHerd.Remove(currentDinosaur);
                        deadDinos++;
                        break;
                    }
                }

                if (deadDinos == 3)
                {
                    Console.WriteLine("The Robots have defeated the Dinosaurs!!");
                    Console.ReadLine();
                }
                else if (deadRobots == 3)
                {
                    Console.WriteLine("The Dinosaurs have defeated the Robots!!");
                    Console.ReadLine();
                }

                fightingHerd.dinosaurHerd[dinoSelect].DinoAttack(fightingFleet.robotFleet[roboSelect]);
                fightingFleet.robotFleet[roboSelect].RoboAttack(fightingHerd.dinosaurHerd[dinoSelect]);

                roundCounter++;
            }            
        }
    }
}
