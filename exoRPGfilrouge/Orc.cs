using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Orc : Monstre
    {
        public override int Force
        {
            get { return base.Force + 3; }
            set { base.Force = value; }
        }

        public override int Endu
        {
            get { return base.Endu + 2; }
            set { base.Endu = value; }
        }
        public void CoupDeHache()
        {
            Console.WriteLine($"le {this.GetType().Name} attaque avec un coup de hache ! ");
        }
        public void CriDeGuerre()
        {
            Console.WriteLine($"le {this.GetType().Name} lance un cri de guerre ! ");
        }
    }
}
