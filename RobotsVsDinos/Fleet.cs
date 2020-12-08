using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Fleet
    {
        //MEMBER VARIABLES (what it has)
        public List<Robot> robotFleet;

        //CONSTRUCTOR (spawner)
        public Fleet()
        {
            robotFleet = new List<Robot>();
            robotFleet.Add(new Robot("Megatron", 100, 100, new Weapon("Missiles", 100)));
            robotFleet.Add(new Robot("Optimus Prime", 150, 85, new Weapon("Sword", 65)));
            robotFleet.Add(new Robot("Starscream", 70, 120, new Weapon("Minigun", 110)));
        }
        //MEMBER METHODS (what can it do)
      
    }
}
