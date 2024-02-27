using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.MesClasses
{
    internal class MaPartie
    {
        public List<Monstre> rencontres = new List<Monstre>();


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
            }

        }

    }

}

