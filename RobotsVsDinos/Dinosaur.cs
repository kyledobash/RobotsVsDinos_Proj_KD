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
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //CONSTRUCTOR (spawner)
        public Dinosaur(string inputType, int inputHealth, int inputEnergy, int inputAttackPower)
        {
            this.type = inputType;
            this.health = inputHealth;
            this.energy = inputEnergy;
            this.attackPower = inputAttackPower;
        }

        //MEMBER METHODS (what can it do)
        public void DinoAttack(Robot inputRobot)
        {
            Random rnd = new Random();
            int attackChance = rnd.Next(0, 101);

            if (attackChance > 50)
            {
                inputRobot.health -= (attackPower / 2);

            }
            else
            {
                return;
            }
        }
    }
}
