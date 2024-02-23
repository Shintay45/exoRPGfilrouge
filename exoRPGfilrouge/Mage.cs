using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Mage
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

        public void CreationStat()
        {
            //RandomStats rs = new RandomStats();
            Force = RandomStats.CalculStat();
            Endu = RandomStats.CalculStat();
            Intel = RandomStats.CalculStat();
            Sagesse = RandomStats.CalculStat();
        }

        private int _force;

        public int Force
        {
            get { return _force; }
            set {  _force = value; }          
        }

        private int _endu;

        public int Endu
        {
            get { return _endu; }
            set { _endu = value; }
        }

        private int _intel;

        public int Intel
        {
            get { return _intel; }
            set { _intel = value + 4; }
        }

        private int _sagesse;

        public int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value + 2; }
        }
    }
}
