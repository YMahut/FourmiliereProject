using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Larve : Fourmi
    {
        int ageMaxLarve;

        public int AgeMaxLarve
        {
            get { return ageMaxLarve; }
            set { ageMaxLarve = value; }
        }
        public Larve() : base()
        {
            this.ageMaxLarve = 10;
        }
    }
}
