using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class RandomStats
    {
        public static int CalculStat()
        {
            Random random = new Random();

            int stat = 0;
            stat += random.Next(10, 20);

            return stat;
        }
    }
}
