using exoRPGfilrouge.loots;
using exoRPGfilrouge.MesClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{
    public class Boutique
    {
        public static void Shop(List<Equipement> listeEquipement, Personnage personnage)
        {
            
            bool quitter = false;
            do
            {
                Console.WriteLine(" Bienvenue à la boutique d'equipement ! ");
                Console.WriteLine(" Servez-vous ! Mais j'espère que vous avez de l'or...");
                Console.WriteLine($" vous avez {personnage.Or} pieces d'or ");
                int compteur = 1;
                foreach (Equipement item in listeEquipement)
                {
                    Console.WriteLine($"{compteur} . {item.Nom}");
                    Console.WriteLine($"Prix : { item.Prix} or ");
                    compteur++;
                }
                Console.WriteLine($"{compteur} . Quitter.");

                int choix = int.Parse(Console.ReadLine());
                if (choix != 7 )
                {
                    if (personnage.Or <= 0)
                    {
                        Console.WriteLine(" Va farmer fénéant !");
                    }
                    else
                    {
                        Console.WriteLine($" Voici votre {listeEquipement[choix - 1].Nom} ");
                        personnage.Equipements.Add(listeEquipement[choix - 1]);
                        personnage.Or -= listeEquipement[choix - 1].Prix;
                    }
                    Console.WriteLine($" vous n'avez plus que {personnage.Or} or ");
                }
                else { quitter = true; }
                

            } while (!quitter && personnage.Or > 0);
            Console.WriteLine(" Merci de votre visite, à la prochaine, et tachez de rester en vie héhéhé...");
            personnage.ShowCharacterProfile();
            personnage.AfficherInventaire();
            





        }





    }
}
