using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exoRPGfilrouge
{

    public abstract class Entite
    {

        protected int _force;

        public virtual int Force
        {
            get { return _force ; }
            set { _force = value; }
        }

        protected int _endu;

        public virtual int Endu
        {
            get { return _endu ; }
            set { _endu = value; }
        }
        protected int _pdVie;
        public virtual int PdVie
        {
            get { return _pdVie + Bonus(Endu); }
            set { _pdVie = value; }
        }

        public abstract void CreationStat();

        public abstract void ShowCharacterProfile();

        public int Bonus(int stat)
        {
            if (stat < 10)
            {
               return -1;
            }
            else if (stat <13)
            {
                return 0;
            }
            else if (stat < 16)
            {
                return 1;
            }
            else if (stat < 19)
            {
                return 2;
            }
            else 
            {
                return 3;
            }
        }
    }
}