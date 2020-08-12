using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Battlefield
    {
        public double battleNumber = 0;
        Fleet fleet = new Fleet();
        Herd herd = new Herd();
        Random rand = new Random();


        //All the robots attack the first dinosaur until his health is dead and vice versa
        public void AttackingDino()
        {
            if (fleet.robots.Count == 3)
            {
                fleet.robots[0].AttackDino(herd.dinosaurs[0]);
                fleet.robots[1].AttackDino(herd.dinosaurs[0]);
                fleet.robots[2].AttackDino(herd.dinosaurs[0]);
            }
            else if (fleet.robots.Count == 2)
            {
                fleet.robots[0].AttackDino(herd.dinosaurs[0]);
                fleet.robots[1].AttackDino(herd.dinosaurs[0]);
            }
            else if (fleet.robots.Count == 1)
            {
                fleet.robots[0].AttackDino(herd.dinosaurs[0]);
            }
            
        }


        public void AttackingRobot()
        {
            if (herd.dinosaurs.Count == 3)
            {
                herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
                herd.dinosaurs[1].AttackRobot(fleet.robots[0]);
                herd.dinosaurs[2].AttackRobot(fleet.robots[0]);
            }
            else if (herd.dinosaurs.Count == 2)
            {
                herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
                herd.dinosaurs[1].AttackRobot(fleet.robots[0]);
            }
            else if (herd.dinosaurs.Count == 1)
            {
                herd.dinosaurs[0].AttackRobot(fleet.robots[0]);
            }
            


        }

        public void BattleOverview()
        {
            battleNumber++;
            Console.WriteLine($"After Battle {battleNumber}, the match stats are: ");
            Console.WriteLine(" ");
            Console.ReadLine();

            foreach(Robot robot in fleet.robots)
            {
                Console.WriteLine($"Robot: {robot.name}. His Health is: {robot.health} ");
                Console.WriteLine("--------------------");
                
            }
            Console.ReadLine();
            foreach (Dinosaur dinosaur in herd.dinosaurs)
            {
                Console.WriteLine($"Dinosaur: {dinosaur.type}  Health: {dinosaur.health} ");
                Console.WriteLine("--------------------");
                
            }
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            


        }

        public void RunBattle()
        {
            while (fleet.robots.Count >= 1 && herd.dinosaurs.Count >= 1)
            {
                int randomNumber = rand.Next(1, 3);
                
                if (randomNumber == 1)
                {
                    AttackingRobot();
                    Console.WriteLine("The Dinosaurs attacked the robots!");
                    Console.WriteLine(" ");
                    
                }
                else
                {
                    AttackingDino();
                    Console.WriteLine("The Robots attacked the Dinosaurs! ");
                    Console.WriteLine(" ");
                    
                }
                

                BattleOverview();

                fleet.RobotDying();
                herd.DinoDying();
                
            }

            ConclusionOfBattle();
        }

        public void ConclusionOfBattle()
        {
            if (fleet.robots.Count == 0)
            {
                Console.WriteLine("The war is over, the Dinosaurs have won!");
                Console.ReadLine();
            }
            else if (herd.dinosaurs.Count == 0)
            {
                Console.WriteLine("The war is over, the Robots have won!");
                Console.ReadLine();
            }
        }
        
    }

}
