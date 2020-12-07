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
        public string name;
        public int health;
        public int powerLevel;
        public int attackPower;
        public Weapon weapon;
        public bool isTurn;

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
        public void RoboAttack(Robot inputRobot, Dinosaur inputDinosaur)
        {
            Random rnd = new Random();
            int attackChance = rnd.Next(0, 101);

            if (inputRobot.isTurn == true && attackChance > 50)
            {
                inputDinosaur.health -= (inputRobot.powerLevel / 2);
                inputRobot.isTurn = !inputRobot.isTurn;
                inputDinosaur.isTurn = !inputDinosaur.isTurn;
            }
            else if (inputRobot.isTurn == true && attackChance < 50)
            {
                inputRobot.isTurn = !inputRobot.isTurn;
                inputDinosaur.isTurn = !inputDinosaur.isTurn;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
