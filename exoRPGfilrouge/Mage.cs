using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Mage : Personnage
    {
  

       

       

        public override int Intel
        {
            get { return base.Intel + 4; }
            set { base.Intel = value; }
        }

        

        public override int Sagesse
        {
            get { return base.Sagesse + 2; }
            set { base.Sagesse = value; }
        }
    }
}
