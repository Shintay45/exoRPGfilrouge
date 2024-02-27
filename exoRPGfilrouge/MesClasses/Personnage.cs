using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.MesClasses
{
    public class Personnage : Entite
    {
        public string Nom { get; set; }
        protected int _intel;
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
        public override void CreationStat()
        {
            Console.Write("Choisissez votre nom : ");
            Nom = Console.ReadLine();
            Force = Tools.CalculStat();
            Endu = Tools.CalculStat();
            Intel = Tools.CalculStat(); 
            Sagesse = Tools.CalculStat();
        }
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endu} ({_endu})");
            Console.WriteLine($"Intel : {Intel} ({_intel})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");

        }

    }
}
