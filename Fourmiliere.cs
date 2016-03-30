using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Fourmiliere
    {
        public static List<Fourmi> listFourmi = new List<Fourmi>();

        public List<Fourmi> ListFourmi
        {
            get { return listFourmi; }
            set { listFourmi = value; }
        }

        public Fourmiliere(int nbReine, int nbLarve, int nbOuvriere, int nbMale)
        {
            for (int i = 0; i < nbReine; i++)
            {
                listFourmi.Add(new Reine());
            }
            for (int i = 0; i < nbOuvriere; i++)
            {
                listFourmi.Add(new Ouvriere());
            }
            for (int i = 0; i < nbLarve; i++)
            {
                listFourmi.Add(new Larve());
            }
            for (int i = 0; i < nbMale; i++)
            {
                listFourmi.Add(new Male());
            }
        }

        public Boolean updateJournalier()
        {
            int nbReine = 0;
            if (listFourmi.Count() != 0)
            {
                foreach (Fourmi fourmi in listFourmi)
                {
                    ++fourmi.AgeFourmi;
                    if (fourmi is Reine) {
                        ++nbReine;
                    }
                }
                if (checkMaleAndReine())
                {
                    for (int j = 0; j < nbReine; j++) {
                        for (int i = 0; i < 10; i++)
                        {
                            ListFourmi.Add(new Larve());
                        }
                    }
                }


                checkAge();
                return true;
            }
            else {
                return false;
            }
        }

        public void checkAge()
        {
            var listTmp = listFourmi.ToList();
            Random rand = new Random();

            foreach (Fourmi fourmi in listTmp)
            {
                if (fourmi is Reine)
                {
                    if (((Reine)fourmi).AgeMaxReine < fourmi.AgeFourmi)
                    {
                        listFourmi.Remove(fourmi);
                    }
                };
                if (fourmi is Ouvriere)
                {
                    if (((Ouvriere)fourmi).AgeMaxOuvriere < fourmi.AgeFourmi)
                    {
                        listFourmi.Remove(fourmi);
                    }
                };
                if (fourmi is Larve)
                {
                    if (((Larve)fourmi).AgeMaxLarve < fourmi.AgeFourmi)
                    {
                        listFourmi.Remove(fourmi);

                        if (rand.Next(0,100) < 5)
                        {
                            listFourmi.Add(new Reine());
                        }
                        else
                        {
                            if (rand.Next(0,100) < 10)
                            {
                                listFourmi.Add(new Male());
                            }
                            else
                            {
                                listFourmi.Add(new Ouvriere());
                            }
                        }


                    }
                };
                if (fourmi is Male)
                {
                    if (((Male)fourmi).AgeMaxMale < fourmi.AgeFourmi)
                    {
                        listFourmi.Remove(fourmi);
                    }
                };
            }

        }

        public Boolean checkMaleAndReine()
        {
            Boolean reine = false;
            Boolean male = false;
            foreach (Fourmi fourmi in listFourmi)
            {
                if (fourmi is Male) {
                    male = true;
                } else if (fourmi is Reine) {
                    reine = true;
                }

                if (male && reine)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

