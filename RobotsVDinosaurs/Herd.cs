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
        public List<Dinosaur> dinosaurs = new List<Dinosaur>();
       


        public Herd()
        {
            dino1 = new Dinosaur("Tryannosaurus", 100, 100, 170);
            dino2 = new Dinosaur("Triceratops", 120, 100, 120);
            dino3 = new Dinosaur("Velociraptor", 120, 100, 140);
            dinosaurs.Add(dino1);
            dinosaurs.Add(dino2);
            dinosaurs.Add(dino3);
        }

        public void DinoDying()
        {
            if (dino1.health <= 0)
            {
                dinosaurs.Remove(dino1);
            }
            if (dino2.health <= 0)
            {
                dinosaurs.Remove(dino2);
            }
            if (dino3.health <= 0)
            {
                dinosaurs.Remove(dino3);
            }
        }
    }
}
