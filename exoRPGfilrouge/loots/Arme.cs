﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.loots
{
    
    internal class Arme : Equipement
    {
        public int nbD { get; set; }
        public int face { get; set; }
        public int DegatsArme()
        {
            Random rnd = new Random();
            
            return nbD * rnd.Next(1, face);
        }
    }
}
