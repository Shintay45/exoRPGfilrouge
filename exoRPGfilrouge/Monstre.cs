using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Monstre
    {
        private int _force;

        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endu;

        public virtual int Endu
        {
            get { return _endu; }
            set { _endu = value; }
        }


        internal class RandomStatsMonstre
        {
            public static int CalculStatMonstre()
            {
                Random random = new Random();

                int stat = 0;
                stat += random.Next(10, 21);

                return stat;
            }
        }

        public void CreationStatMonstre()
        {
            
            RandomStatsMonstre rs = new RandomStatsMonstre();
            Force = RandomStatsMonstre.CalculStatMonstre();
            Endu = RandomStatsMonstre.CalculStatMonstre();
            
        }
    }
}
