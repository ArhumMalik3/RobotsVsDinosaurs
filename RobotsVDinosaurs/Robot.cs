using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Robot
    {
        //memeber variables
        public string name;
        public double health;
        public double powerLevel;
        public Weapon weaponType;
        public double attackPower;

        //Constructor
        public Robot(string name, double health, double powerLevel, Weapon weaponType, double attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weaponType = weaponType;
            this.attackPower = attackPower;

        }

        public void AttackDino(Dinosaur dino) /*Dinosaur dinoTwo, Dinosaur dinoThree)*/
        {
            if (attackPower >= 120)
            {
                dino.health -= 20;
                //dinoTwo.health -= 20;
                //dinoThree.health -= 20;

            }
            else if (attackPower >= 110)
            {
                dino.health -= 15;
                //dinoTwo.health -= 15;
                //dinoThree.health -= 15;
            }
            else if (attackPower >= 100)
            {
                dino.health -= 10;
                //dinoTwo.health -= 10;
                //dinoThree.health -= 10;
            }
            else if (attackPower >= 90)
            {
                dino.health -= 7;
                //dinoTwo.health -= 7;
                //dinoThree.health -= 7;
            }
            else
            {
                dino.health -= 4;
                //dinoTwo.health -= 4;
                //dinoThree.health -= 4;
            }
        }
    }
}
