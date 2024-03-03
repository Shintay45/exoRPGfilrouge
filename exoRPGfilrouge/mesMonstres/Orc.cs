using exoRPGfilrouge.loots;
using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesMonstres
{
    public class Orc : Monstre , IInventaire , Ior
    {
        public override int Force
        {
            get { return base.Force + 3; }
            set { base.Force = value; }
        }

        public override int Endu
        {
            get { return base.Endu + 2; }
            set { base.Endu = value; }
        }

        public List<Equipement> Loot { get ; set ; }
        public int Or { get ; set ; }

        public void CoupDeHache()
        {
            Console.WriteLine($"le {GetType().Name} attaque avec un coup de hache ! ");
        }
        public void CriDeGuerre()
        {
            Console.WriteLine($"le {GetType().Name} lance un cri de guerre ! ");
            
        }
        public override void CreationStat()
        {
            Random rnd = new Random ();
            base.CreationStat();            
            Or = rnd.Next(0, 7);            
        }
        public void AtribuerLoot(List<Equipement> equipements)
        {
            GenererInventaire(equipements);
        }
        public void GenererInventaire(List<Equipement> equipements)
        {
            Random rnd = new Random();
            Loot = new List<Equipement>();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    break;
                case 1:
                    Loot.Add(equipements[rnd.Next(0, equipements.Count)]);
                    break;
                case 2:
                    Loot.Add(equipements[rnd.Next(0, equipements.Count)]);
                    Loot.Add(equipements[rnd.Next(0, equipements.Count)]);
                    break;
            }
        }
        public void AfficheLootOrc()
        {
            foreach (Equipement item in Loot)
            {
                Console.WriteLine(item.Nom);
            }
        }
    }
}
