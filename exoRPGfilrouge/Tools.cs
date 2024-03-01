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
            Random random = new Random();

            int statbase = 0;
            statbase += random.Next(10, 21);

            return statbase;
        }

    }
}
