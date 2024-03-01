using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesMonstres
{
    internal class Loup : Monstre
    {
        public override int Force
        {
            get { return base.Force + 2; }
            set { base.Force = value; }
        }

        public override int Endu
        {
            get { return base.Endu + 1; }
            set { base.Endu = value; }
        }
        public void Morsure()
        {
            Console.WriteLine($"le {GetType().Name} attaque avec une morsure ! ");
        }
        public void Hurlement()
        {
            Console.WriteLine($"le {GetType().Name} pousse un hurlement qui vous glace le sang ! ");
        }
    }
}
