using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Robot
    {
        //MEMBER VARIABLES (what it has)
        string name;
        int health;
        int powerLevel;
        int attackPower;
        Weapon weapon;

        //CONSTRUCTOR (spawner)
        public Robot(string inputName, int inputHealth, int inputPowerLevel, int inputAttackPower, Weapon inputWeapon)
        {
            this.name = inputName;
            this.health = inputHealth;
            this.powerLevel = inputPowerLevel;
            this.weapon = inputWeapon;
            this.attackPower = inputAttackPower;
        }

        //MEMBER METHODS (what can it do)
    }
}
