
namespace exoRPGfilrouge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Guerrier guerrier = new Guerrier();
            guerrier.ShowCharacterProfile();
            

            Mage mage = new Mage();
            mage.ShowCharacterProfile();
           

            Pretre pretre = new Pretre();
            pretre.ShowCharacterProfile();
                              
        }
    }
}
