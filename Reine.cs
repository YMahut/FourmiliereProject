using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Reine : Fourmi
    {
        int ageMaxReine;

        public int AgeMaxReine
        {
            get { return ageMaxReine; }
            set { ageMaxReine = value; }
        }

        public Reine() : base()
        {
            this.ageMaxReine = 40;
        }
    }
}
