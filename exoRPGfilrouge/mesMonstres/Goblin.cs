using exoRPGfilrouge.loots;
using exoRPGfilrouge.mesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesMonstres
{
    internal class Goblin : Monstre , IInventaire , Ior
    {
        public override int Force
        {
            get { return base.Force - 1; }
            set { base.Force = value; }
        }
        

        public List<Equipement> Loot { get ; set; }
        public int Or { get ; set ; }

        public void CoupDeMasse()
        {
            Console.WriteLine($"le {GetType().Name} attaque avec un coup de masse, ca fait mal ! ");
            
        }
        public void GenererInventaire(List<Equipement> listeLoot)
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
        public override void CreationStat()
        {
            Random rnd = new Random();
            base.CreationStat();
            
            Or = rnd.Next(0, 7);
            

        }

        public void AtribuerLoot (List<Equipement> listeLoot)
        {
            GenererInventaire(listeLoot);
        }
        public void AffichelootGoblin()
        {
            foreach (Equipement item in Loot)
            {
                Console.WriteLine(item.Nom);
            }
        }
    }

}
