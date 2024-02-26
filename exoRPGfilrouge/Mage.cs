using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Mage : Personnage
    {
        public string Nom { get; set; }

        public Mage()
        {
            Console.Write("Veuillez entrer votre nom pour un mage :");
            Nom = Console.ReadLine();

            while (string.IsNullOrEmpty(Nom))
            {
                Console.Write("Veuillez ecrire un nom svp :");
                Nom = Console.ReadLine();
            }

            CreationStat();
        }

        private int _intel;

        public override int Intel
        {
            get { return _intel + 4; }
            set { _intel = value; }
        }

        private int _sagesse;

        public override int Sagesse
        {
            get { return _sagesse + 2; }
            set { _sagesse = value; }
        }
    }
}
