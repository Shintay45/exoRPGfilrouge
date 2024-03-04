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
            get { return _pdVie + Tools.Bonus(Endu); }
            set { _pdVie = value; }
        }

        public abstract void CreationStat();

        public abstract void ShowCharacterProfile();

        
    }
}