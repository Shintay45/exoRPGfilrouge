
using exoRPGfilrouge.MesClasses;
using exoRPGfilrouge.mesMonstres;

namespace exoRPGfilrouge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaPartie maPartie = new MaPartie();

            while (maPartie.joueur.PdVie > 0)
            {
                Console.WriteLine("Que voulez vous faire ?");
                Console.WriteLine("1 - Boutique");
                Console.WriteLine("2 - Combat");
                int choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        maPartie.EntrerBoutique();
                        break;

                    case 2:
                        Combat c = new Combat();
                        Random random = new Random();
                        int monstreIndex = random.Next(0, maPartie.rencontres.Count);
                        Monstre aFrapper = maPartie.rencontres[monstreIndex];
                        c.MonCombat(maPartie.joueur, aFrapper);
                        if (maPartie.joueur.PdVie > 0 && aFrapper is Orc)
                        {
                            maPartie.joueur.Equipements.AddRange(((Orc)aFrapper).Loot);
                        }
                        if (maPartie.joueur.PdVie > 0 && aFrapper is Goblin)
                        {
                            maPartie.joueur.Equipements.AddRange(((Goblin)aFrapper).Loot);   
                        }
                        maPartie.rencontres.Remove(aFrapper);

                        break;

                }
            }

            if (maPartie.joueur.PdVie <= 0)
            {
                Console.WriteLine("Tu t'es fais défoncé");
            }
            else
            {
                Console.WriteLine("T'as tout niqué");
            }
        }
    }
}
