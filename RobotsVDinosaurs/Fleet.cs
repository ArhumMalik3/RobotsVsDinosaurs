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
        public List<Robot> robots;
        Weapon Sword = new Weapon(3);

        //Constructor
        public Fleet()
        {
            robot1 = new Robot("Optimus Prime", 100, 4, Sword, 105);
            robot2 = new Robot("John", 90, 6, Sword, 120);
            robot3 = new Robot("Bob", 95, 5, Sword, 110);



        }
    }
}
