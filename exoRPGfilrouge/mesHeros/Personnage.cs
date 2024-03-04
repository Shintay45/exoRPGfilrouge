using exoRPGfilrouge.loots;
using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exoRPGfilrouge;
using exoRPGfilrouge.mesMonstres;
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

        protected int _sagesse;
        public virtual int Sagesse
        {
            get { return _sagesse ; }
            set { _sagesse = value; }
        }
        
        public List<Equipement> Equipements { get; set; } = new List<Equipement>();
        
        public override void CreationStat()
        {
            Equipements = new List<Equipement>();
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
            Console.WriteLine($"Force : ({_force}) de base | ({Force}) modifiée |({Tools.Bonus(Force)}) de modificateur");
            Console.WriteLine($"Endu : ({_endu}) de base | ({Endu}) modifiée | ({Tools.Bonus(Endu)}) de modificateur");
            Console.WriteLine($"Intel : ({_intel}) de base | ( {Intel} ) modifiée | ( {Tools.Bonus(Intel)} ) de modificateur");
            Console.WriteLine($"Sagesse : ({_sagesse}) de base | ( {Sagesse} ) modifiée | ( {Tools.Bonus(Sagesse)} ) de modificateur");
            Console.WriteLine($"point de vie : {_pdVie} de base | ({PdVie}) modifiée ");
            Console.WriteLine($"Or : {Or}");
            Console.WriteLine("______________________________");

        }
        public void AfficherInventaire()
        {
            int counter = 1;
            Console.WriteLine("Inventaire : ");
            foreach ( Equipement item in Equipements )
            {
                Console.WriteLine($"{counter} - {item.Nom}");
            }
        }
        
    }
}
