using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Male : Fourmi
    {
        int ageMaxMale;

        public int AgeMaxMale
        {
            get { return ageMaxMale; }
            set { ageMaxMale = value; }
        }
        public Male() : base()
        {
            this.ageMaxMale = 15;
        }
    }
}
