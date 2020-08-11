using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Fleet
    {
        public List<Weapon> weapons;
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;
        public List<Robot> robots = new List<Robot>();
        
        Weapon Sword = new Weapon(3);

        //Constructor
        public Fleet()
        {
            robot1 = new Robot("Optimus Prime", 100, 4, Sword, 105);
            robot2 = new Robot("R2-D2", 90, 6, Sword, 120);
            robot3 = new Robot("Mars Rover", 95, 5, Sword, 110);
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }

        public void RobotDying()
        {
            if (robot1.health <= 0)
            {
                robots.Remove(robot1);
            }
            if (robot2.health <= 0)
            {
                robots.Remove(robot2);
            }
            if (robot3.health <= 0)
            {
                robots.Remove(robot3);
            }
        }

    }
    
}
