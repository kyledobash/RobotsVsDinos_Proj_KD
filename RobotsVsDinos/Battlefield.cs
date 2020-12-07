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
        public int roundCounter;

        //CONSTRUCTOR (spawner)
        public Battlefield()
        {
            this.roundCounter = 0;
        }

        //MEMBER METHODS (what can it do)
        public void EndGame(List<Robot> robotFleet, List<Dinosaur> dinosaurHerd)
        {
            //iterate over both lists
            //if all members of list health is < 0, end the game.
            int deadRobots = 0;
            int deadDinos = 0;

            foreach (Robot currentRobot in robotFleet)
            {
                if (currentRobot.health <= 0)
                {
                    deadRobots++;
                }
            }
            foreach (Dinosaur currentDinosaur in dinosaurHerd)
            {
                if (currentDinosaur.health <= 0)
                {
                    deadDinos++;
                }
            }

            if (deadDinos == 3 || deadRobots == 3)
            {
                //end game
                roundCounter = 0;
            }
        }
    }
}
