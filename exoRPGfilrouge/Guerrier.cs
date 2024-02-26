using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Guerrier : Personnage
    {
        public string Nom {  get; set; }

        public Guerrier()
        {
            Console.Write("Veuillez entrer votre nom pour un guerrier :");
            Nom = Console.ReadLine();

            while (string.IsNullOrEmpty(Nom))
            {
                Console.Write("Veuillez ecrire un nom svp :");
                Nom = Console.ReadLine();
            }

            CreationStat();
        }

        private int _force;

        public override int Force
        {
            get { return _force + 3; }
            set { _force = value; }
        }

        private int _endu;

        public override int Endu
        {
            get { return _endu + 3; }
            set { _endu = value  ; }
        }

    }
    
}
