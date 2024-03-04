using exoRPGfilrouge.loots;
using exoRPGfilrouge.MesClasses;
using exoRPGfilrouge.mesMonstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class Combat
    {

        public void MonCombat(Personnage p, Monstre m)
        {
            while(p.PdVie > 0 && m.PdVie > 0)
            {
                FightPvsM(p, m);
                FightMvsP(p, m);
            }
        }

        public void FightPvsM(Personnage p, Monstre m)
        {
            
                Console.WriteLine("Quelle arme utilisé ?");
                p.AfficherInventaire();
                int choix = -1;
                while(choix < 0 || choix > p.Equipements.Count)
                {
                    choix = int.Parse(Console.ReadLine());
                }

                if (p.Equipements[choix -1] is Arme)
                {
                    Arme arme = (Arme)p.Equipements[choix -1];
                    Frapper(arme.nbD, arme.face, Tools.Bonus(p.Force), m);
                }
            
        }

        public void FightMvsP(Personnage p, Monstre m)
        {
            switch (m) {
                case Goblin g: Frapper(1, 4, Tools.Bonus(m.Force), p);
                    break;
                case Loup l: Frapper(1, 6, Tools.Bonus(m.Force), p); break;
                case Orc o: Frapper(1, 8, Tools.Bonus(m.Force), p); break;
            }
        }

        public void Frapper(int nbDes, int nbFaces, int modificateur, Entite cible)
        {
            int degat = Tools.MonLancer(nbDes, nbFaces) + modificateur;
            cible.PdVie = cible.PdVie - degat;
        }

    }

    
}
