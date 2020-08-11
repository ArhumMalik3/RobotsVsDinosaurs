using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Battlefield
    {
        Fleet fleet = new Fleet();
        Herd herd = new Herd();

        public void AttackingDino()
        {
            fleet.robot1.AttackDino(herd.dino1);
            Dinosaur dino = herd.dino1;
            //fleet.robot2.AttackDino(herd.dino2);
            //Dinosaur dinoTwo = herd.dino2;
            //fleet.robot3.AttackDino(herd.dino3);
            //Dinosaur dinoThree = herd.dino3;

        }


        public void AttackingRobot()
        {
            herd.dino1.AttackRobot(fleet.robot1);
            Robot robo = fleet.robot1;

        }
        public void RunBattle()
        {
            if (fleet.robot1.health > 0 && herd.dino1.health > 0)
            {
                AttackingRobot();
                AttackingDino();
                double newRobotHealth = fleet.robot1.health;
                double newDinoHealth = herd.dino1.health;
                Console.WriteLine($"The Robots health is {newRobotHealth}. The Dinosaurs health is {newDinoHealth}. ");
                Console.ReadLine();



               
            }
            else
            {
                ConclusionOfBattle();
            }


        }

        public void ConclusionOfBattle()
        {
            if (fleet.robot1.health <= 0 || fleet.robot2.health <= 0 || fleet.robot3.health <= 0)
            {
                Console.WriteLine("The battle is over, the Dinosaurs have won!");
                Console.ReadLine();
            }
            else if (herd.dino1.health <= 0 || herd.dino2.health <= 0 || herd.dino3.health <= 0)
            {
                Console.WriteLine("The battle is over, the Robots have won!");
                Console.ReadLine();
            }
        }
        
    }

}
