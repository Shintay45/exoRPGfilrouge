using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exoRPGfilrouge.loots;
using exoRPGfilrouge.MesClasses;
using exoRPGfilrouge.mesMonstres;

namespace exoRPGfilrouge
{
    internal class MaPartie
    {
        public List<Monstre> rencontres = new List<Monstre>();      
        public static List< Equipement> MaPartie1()
        {
            List< Equipement> listeEquipement = new List<Equipement>();

            Arme epeeCourte = new Arme();
            epeeCourte.Nom = "Epée courte";
            epeeCourte.Prix = 15;
            epeeCourte.nbD = 1;
            epeeCourte.face = 6;
            listeEquipement.Add( epeeCourte);
            Arme epeeLongue = new Arme();
            epeeLongue.Nom = "Epee longue";
            epeeLongue.Prix = 25;
            epeeLongue.nbD = 1;
            epeeLongue.face = 8;
            listeEquipement.Add(epeeLongue);
            Arme baton = new Arme();
            baton.Nom = "Baton";
            baton.Prix = 10;
            baton.nbD = 1;
            baton.face = 4;
            listeEquipement.Add(baton);
            Consommables potionVie = new Consommables();
            potionVie.Nom = "potion de vie";
            potionVie.Prix = 20;
            potionVie.nbD = 2;
            potionVie.face = 4;
            listeEquipement.Add(potionVie);            
            Armure armureCuir = new Armure();
            armureCuir.Nom = "armure de cuir";
            armureCuir.Prix = 20;
            armureCuir.Defense = 2;
            listeEquipement.Add(armureCuir);
            Armure armurePlate = new Armure();
            armurePlate.Nom = " armure en plate";
            armurePlate.Prix = 50;
            armurePlate.Defense = 5;
            listeEquipement.Add( armurePlate);

            return listeEquipement;           
        }

        public void GenerationRencontres()
        {
            Random random = new Random();
            Monstre monstre;
            for (int i = 0; i < 10; i++)
            {

                int Lance = random.Next(1, 7);

                if (Lance == 1)
                {
                    monstre = new Orc();
                    monstre.CreationStat();
                    rencontres.Add(monstre);
                }
                else if (Lance == 2 || Lance == 3)
                {
                    monstre = new Loup();
                    monstre.CreationStat();
                    rencontres.Add(monstre);
                }
                else
                {
                    monstre = new Goblin();
                    monstre.CreationStat();
                    rencontres.Add(monstre);
                }
            }
        }

        public void AfficherHorde()
        {
            foreach (Monstre listhorde in rencontres)
            {
                listhorde.ShowCharacterProfile();
                switch (listhorde)
                {
                    case Goblin G:
                        G.CoupDeMasse();
                        G.AffichelootGoblin();
                        Console.WriteLine("------------------------------");
                        break;
                    case Loup L:
                        L.Morsure();
                        L.Hurlement();
                        Console.WriteLine("------------------------------");
                        break;
                    case Orc O:
                        O.CoupDeHache();
                        O.CriDeGuerre();
                        O.AfficheLootOrc();
                        Console.WriteLine("------------------------------");
                        break;
                }
            }
        }
    }
}

