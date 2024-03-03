using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.MesClasses
{
    public class Pretre : Personnage
    {

        public override int Intel
        {
            get { return base.Intel + 2; }
            set { base.Intel = value; }
        }

        public override int Sagesse
        {
            get { return base.Sagesse + 4; }
            set { base.Sagesse = value; }
        }
    }
}
