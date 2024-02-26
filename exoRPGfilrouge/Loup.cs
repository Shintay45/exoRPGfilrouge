using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
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
            
            Console.WriteLine($"le {this.GetType().Name} attaque avec une morsure ! ");
            
        }
        public void Hurlement()
        {
            Console.WriteLine($"le {this.GetType().Name} hurle a la mort ! ");
        }
    }
}
