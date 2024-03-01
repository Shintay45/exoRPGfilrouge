
using exoRPGfilrouge.MesClasses;

namespace exoRPGfilrouge
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Entite joueur;
            Entite monstre;
            int choix = 0;
            
            while (choix < 1 || choix > 3)
            {
                Console.WriteLine("Quelle classe voulez vous jouer? :");
                Console.WriteLine("1. Guerrier");
                Console.WriteLine("2. Mage");
                Console.WriteLine("3. Pretre");
                

                int.TryParse(Console.ReadLine(), out choix);
            }


            switch (choix)
            {
                case 1:
                    joueur = new Guerrier();
                    break;
                case 2:
                    joueur = new Mage();
                    break;
                case 3:
                    joueur = new Pretre();
                    break;
                default: joueur = null; break;
            }

            joueur.CreationStat();
            joueur.ShowCharacterProfile();
            
            MaPartie maPartie = new MaPartie();
            maPartie.GenerationRencontres();
            maPartie.AfficherHorde();
            
            
            
        }
    }
}
