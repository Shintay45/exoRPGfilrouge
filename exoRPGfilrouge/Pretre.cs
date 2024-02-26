using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Pretre : Personnage
    {
        public string Nom { get; set; }

        public Pretre()
        {
            Console.Write("Veuillez entrer votre nom pour un pretre :");
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
            get { return _intel + 2; }
            set { _intel = value; }
        }

        private int _sagesse;

        public override int Sagesse
        {
            get { return _sagesse + 4; }
            set { _sagesse = value; }
        }
    }
}
