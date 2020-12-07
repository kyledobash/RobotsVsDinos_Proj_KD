using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Dinosaur
    {
        //MEMBER VARIABLES (what it has)
        string type;
        int health;
        int energy;
        int attackPower;

        //CONSTRUCTOR (spawner)
        public Dinosaur(string inputType, int inputHealth, int inputEnergy, int inputAttackPower)
        {
            this.type = inputType;
            this.health = inputHealth;
            this.energy = inputEnergy;
            this.attackPower = inputAttackPower;
        }

        //MEMBER METHODS (what can it do)

    }
}
