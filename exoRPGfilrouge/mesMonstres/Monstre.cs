using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesMonstres
{
    internal class Monstre : Entite
    {
        private int _force;

        public override int Force
        {
            get { return _force; }
            set { _force = value; }
        }

        private int _endu;

        public override int Endu
        {
            get { return _endu; }
            set { _endu = value; }
        }

        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Force : {_force} de base | ({Force}) modifiée");
            Console.WriteLine($"Endu : {_endu} de base | ({Endu}) modifiée");
            Console.WriteLine($"point de vie : {PdVie}");
            if (this is Ior monstreOr) 
            {
                Console.WriteLine($"Or : {monstreOr.Or}");
            }
        }

        public override void CreationStat()
        {
            Force = Tools.CalculStat();
            Endu = Tools.CalculStat();
            PdVie = 10;

        }
    }
}
