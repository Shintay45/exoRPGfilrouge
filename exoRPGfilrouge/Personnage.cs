using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Personnage
    {
        internal class RandomStats
        {
            public static int CalculStat()
            {
                Random random = new Random();

                int stat = 0;
                stat += random.Next(10, 21);

                return stat;
            }
        }

        public void CreationStat()
        {
            //RandomStats rs = new RandomStats();
            Force = RandomStats.CalculStat();
            Endu = RandomStats.CalculStat();
            Intel = RandomStats.CalculStat();
            Sagesse = RandomStats.CalculStat();
        }

        private int _force;

        public virtual int Force
        {
            get { return _force ; }
            set { _force = value; }
        }

        private int _endu;

        public virtual int Endu
        {
            get { return _endu ; }
            set { _endu = value; }
        }

        private int _intel;

        public virtual int Intel
        {
            get { return _intel; }
            set { _intel = value; }
        }

        private int _sagesse;

        public virtual int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
    }
}
