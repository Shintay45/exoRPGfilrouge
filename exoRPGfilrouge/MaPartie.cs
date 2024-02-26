using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    internal class MaPartie
    {
        List<Monstre> rencontres = new List<Monstre>();
 
        
        public void GenerationRencontres()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {

                int Lance = random.Next(1, 7);

                if (Lance == 1)
                {
                    rencontres.Add(new Orc());
                }
                else if (Lance == 2 || Lance == 3)
                {
                    rencontres.Add(new Loup());
                }
                else
                {
                    rencontres.Add(new Goblin());
                }
            }

        }

        public void AfficherHorde()
        {
            foreach (Monstre listhorde in rencontres)
            {
                Console.WriteLine(listhorde);
            }

        }

    }
        
}

