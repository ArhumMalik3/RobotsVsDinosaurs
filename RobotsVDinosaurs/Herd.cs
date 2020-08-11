using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinosaurs
{
    class Herd
    {
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public Herd()
        {
            dino1 = new Dinosaur("Tryannosaurus", 70, 100, 150);
            dino2 = new Dinosaur("Triceratops", 110, 100, 110);
            dino3 = new Dinosaur("Velociraptor", 90, 100, 160);
        }
    }
}
