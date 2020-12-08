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
        public Weapon weapon;
        public bool isTurn;

        //CONSTRUCTOR (spawner)
        public Robot(string inputName, int inputHealth, int inputPowerLevel, Weapon inputWeapon)
        {
            this.name = inputName;
            this.health = inputHealth;
            this.powerLevel = inputPowerLevel;
            this.weapon = inputWeapon;
        }

        //MEMBER METHODS (what can it do)
        public void RoboAttack(Dinosaur inputDinosaur)
        {
            Random rnd = new Random();
            int attackChance = rnd.Next(0, 101);

            if (attackChance > 50)
            {
                inputDinosaur.health -= (weapon.attackPower / 2);
            }
            else
            {
                return;
            }
        }
    }
}
