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
      
    }
}
