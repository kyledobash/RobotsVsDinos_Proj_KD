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
        List<Robot> robotFleet;

        //CONSTRUCTOR (spawner)
        public Fleet()
        {
            robotFleet = new List<Robot>();
        }
        //MEMBER METHODS (what can it do)
        public void PopulateFleet()
        {
            robotFleet.Add(new Robot("Megatron", 100, 100, 100, new Weapon()));
            robotFleet.Add(new Robot("Optimus Prime", 150, 85, 65, new Weapon()));
            robotFleet.Add(new Robot("Starscream", 70, 120, 110, new Weapon()));
        }
    }
}
