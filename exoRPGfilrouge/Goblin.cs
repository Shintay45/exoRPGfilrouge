using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Goblin : Monstre
    {
        public override int Force
        {
            get { return base.Force - 1; }
            set { base.Force = value; }
        }
        public void CoupDeMasse()
        {
            Console.WriteLine($"le {this.GetType().Name} attaque avec un coup de masse, ca fait mal ! ");
        }

    }
    
}
