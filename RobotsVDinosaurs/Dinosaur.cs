using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Dinosaur
    {
        //member variables
        public string type;
        public double health;
        public double energy;
        public double attackPower;


        //constructor
        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        public void AttackRobot(Robot robo)
        {
            if (attackPower >= 150)
            {
                robo.health -= 40;
            }
            else if (attackPower >= 130)
            {
                robo.health -= 25;
            }
            else if (attackPower >= 120)
            {
                robo.health -= 20;
            }
            else if (attackPower >= 110)
            {
                robo.health -= 15;
            }
            else if (attackPower >= 100)
            {
                robo.health -= 10;
            }
            else if (attackPower >= 90)
            {
                robo.health -= 7;
            }
            else
            {
                robo.health -= 4;
            }
        }
    }
}
