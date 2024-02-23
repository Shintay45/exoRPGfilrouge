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

        }
    }
}
