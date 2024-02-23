namespace exoRPGfilrouge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrier guerrier = new Guerrier();
            Console.WriteLine($"le Guerrier s'appelle {guerrier.Nom}");
            Console.WriteLine($"{guerrier.Nom} à {guerrier.Force} points de force ");
            Console.WriteLine($"{guerrier.Nom} à {guerrier.Endu} point d'endurance ");
            Console.WriteLine($"{guerrier.Nom} à {guerrier.Intel} point d'intelligence ");
            Console.WriteLine($"{guerrier.Nom} à {guerrier.Sagesse} point de sagesse ");

            Mage mage = new Mage();
            Console.WriteLine($"le mage s'appelle {mage.Nom}");
            Console.WriteLine($"{mage.Nom} à {mage.Force} points de force ");
            Console.WriteLine($"{mage.Nom} à {mage.Endu} point d'endurance ");
            Console.WriteLine($"{mage.Nom} à {mage.Intel} point d'intelligence ");
            Console.WriteLine($"{mage.Nom} à {mage.Sagesse} point de sagesse ");

            Pretre pretre = new Pretre();
            Console.WriteLine($"le pretre s'appelle {pretre.Nom}");
            Console.WriteLine($"{pretre.Nom} à {pretre.Force} points de force ");
            Console.WriteLine($"{pretre.Nom} à {pretre.Endu} point d'endurance ");
            Console.WriteLine($"{pretre.Nom} à {pretre.Intel} point d'intelligence ");
            Console.WriteLine($"{pretre.Nom} à {pretre.Sagesse} point de sagesse ");

        }
    }
}
