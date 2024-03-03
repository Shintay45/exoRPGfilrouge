using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.MesClasses
{
    public class Guerrier : Personnage
    {
        public override int Force
        {
            get { return base.Force + 3; }
            set { base.Force = value; }
        }

        public override int Endu
        {
            get { return base.Endu + 3; }
            set { base.Endu = value; }
        }

    }

}
