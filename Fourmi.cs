using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    abstract class Fourmi
    {
        private static int currentId = 0;
        int idFourmi;
        int ageFourmi;

        public int IdFourmi{
            get { return idFourmi; }
            set { idFourmi = value; }
        }
        public int AgeFourmi {
            get { return ageFourmi; }
            set { ageFourmi = value; }
        }

        public int CurrentId{
            get {
                return currentId;
            }
            set {
                currentId = value;
            }
        }

        public Fourmi() {
            this.idFourmi = currentId;
            this.ageFourmi =0;
            ++currentId;
        }
    }
}
