using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Tools
    {

        public static int CalculStat()
        {
            return new Random().Next(10, 21);
        }

        public static int MonLancer(int nbDes, int nbFace)
        {
            return nbDes * new Random().Next(1, nbFace + 1);
        }

        public static int Bonus(int stat)
        {
            if (stat < 10)
            {
                return -1;
            }
            else if (stat < 13)
            {
                return 0;
            }
            else if (stat < 16)
            {
                return 1;
            }
            else if (stat < 19)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

    }
}
