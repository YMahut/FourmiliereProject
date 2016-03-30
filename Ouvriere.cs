using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Ouvriere : Fourmi
    {
        int ageMaxOuvriere;

        public int AgeMaxOuvriere
        {
            get { return ageMaxOuvriere; }
            set { ageMaxOuvriere = value; }
        }
        public Ouvriere() : base()
        {
            this.ageMaxOuvriere = 40;
        }
    }
}
