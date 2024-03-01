using exoRPGfilrouge.loots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge.mesInterfaces
{
    internal interface IInventaire
    {
        List<Equipement> Loot { get; set; }

        public void TableLoot(List<Equipement> listeLoot)
        {
            Random rnd = new Random();
            Loot= new List<Equipement>();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    break;
                case 1:
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
                    break;
                case 2:
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
                    Loot.Add(listeLoot[rnd.Next(0, listeLoot.Count)]);
                    break;
            }
        }
    }
}
