using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.MesClasses
{
    internal class Tools
    {

        public static int CalculStat()
        {
            Random random = new Random();

            int stat = 0;
            stat += random.Next(10, 21);

            return stat;
        }

    }
}
