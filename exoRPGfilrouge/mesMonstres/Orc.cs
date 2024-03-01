using exoRPGfilrouge.loots;
using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesMonstres
{
    internal class Orc : Monstre , IInventaire , Ior
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
            TableLoot(MaPartie.MaPartie1());
            Or = rnd.Next(0, 7);
            
        }
        public void TableLoot(List<Equipement> listeLoot)
        {
            Random rnd = new Random();
            Loot = new List<Equipement>();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    break;
                case 1:
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
                    break;
                case 2:
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
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
