﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinos
{
    public class Herd
    {
        //MEMBER VARIABLES (what it has)
        public List<Dinosaur> dinosaurHerd;

        //CONSTRUCTOR (spawner)
        public Herd()
        {
            dinosaurHerd = new List<Dinosaur>();
            dinosaurHerd.Add(new Dinosaur("T-Rex", 120, 100, 80));
            dinosaurHerd.Add(new Dinosaur("Velociraptor", 90, 150, 60));
            dinosaurHerd.Add(new Dinosaur("Stegasaurus", 150, 90, 60));
        }
        //MEMBER METHODS (what can it do)
    }
}
