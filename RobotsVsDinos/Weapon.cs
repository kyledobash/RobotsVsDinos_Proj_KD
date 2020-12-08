using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Weapon
    {
        //MEMBER VARIABLES (what it has)
        public string type;
        public int attackPower;

        //CONSTRUCTOR (spawner)
        public Weapon(string inputType, int inputAttackPower)
        {
            this.type = inputType;
            this.attackPower = inputAttackPower;
        }

        //MEMBER METHODS (what can it do)
    }
}
