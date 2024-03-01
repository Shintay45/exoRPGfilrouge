using exoRPGfilrouge.loots;
using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exoRPGfilrouge;
namespace exoRPGfilrouge.MesClasses
{
    public class Personnage : Entite, Ior 
    { 
        public string Nom { get; set; }
        protected int _intel;
        public virtual int Intel
        {
            get { return _intel; }
            set { _intel = value; }
        }

        public int Or { get ; set ; }

        private int _sagesse;

        public virtual int Sagesse
        {
            get { return _sagesse ; }

            set { _sagesse = value; }
        }
       
        public List<Equipement> Equipements { get; set; }

        public override void CreationStat()
        {
            Console.Write("Choisissez votre nom : ");
            Nom = Console.ReadLine();
            Force = Tools.CalculStat();
            Endu = Tools.CalculStat();
            Intel = Tools.CalculStat(); 
            Sagesse = Tools.CalculStat();
            Or = 100;
            PdVie = 10;
        }
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Force : {Force} ({_force}) ({Bonus(Force)})");
            Console.WriteLine($"Endu : {Endu} ({_endu}) ({Bonus(Endu)})");
            Console.WriteLine($"Intel : {Intel} ({_intel}) ({Bonus(Intel)})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse}) ({Bonus(Sagesse)})");
            Console.WriteLine($"point de vie : {PdVie} ({_pdVie})");

        }

    }
}
