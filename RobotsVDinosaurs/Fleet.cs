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
        public Robot robot1;// = new Robot("Albert", 100, 4, Sword, 105);
        public Robot robot2;// = new Robot("John", 90, 6, Laser, 120);
        public Robot robot3;// = new Robot("Bob", 95, 5, Gun, 110);

        Weapon Sword = new Weapon(3);

        //Constructor
        public Fleet()
        {
            robot1 = new Robot("Albert", 100, 4, Sword, 105);
            robot2 = new Robot("John", 90, 6, Sword, 120);
            robot3 = new Robot("Bob", 95, 5, Sword, 110);
        }

       
    }
}
