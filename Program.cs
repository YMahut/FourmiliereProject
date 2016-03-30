using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourmilière
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbReine;
            Console.WriteLine("Bienvenue dans la fourmilière! \nChoisissez le nombre de reines:");
            nbReine = int.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez le nombre de mâles:");
            var nbMale = int.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez le nombre de larves:");
            var nbLarve = int.Parse(Console.ReadLine());
            Console.WriteLine("Choisissez le nombre d'ouvrières:");
            var nbOuvriere = int.Parse(Console.ReadLine());
            Console.Clear();
            Fourmiliere maFourmiliere = new Fourmiliere(nbReine,nbLarve, nbOuvriere, nbMale);
            Console.WriteLine($"La fourmilière comporte : {nbReine} reines, {nbMale} mâles, {nbLarve} larves, {nbOuvriere} ouvrières");

            string commande = "tmp";
            Boolean mort = false;
            int jourMort = 0;
            int jour = 0;
            do
            {
                rapportJournalier(maFourmiliere, jour);
                Console.WriteLine("\n\n\nAppuyez sur \"Entrer\" pour passer au jour suivant ou \"j\" pour passer plusieurs jours. (\"q\" pour quitter)");
                commande = Console.ReadLine();
                
                switch (commande)
                {
                    case "j":
                        Console.WriteLine($"Nous sommes au jour {jour} de la fourmilière. \nDe combien de jours souhaitez vous avancer?");
                        var tmp = jour + int.Parse(Console.ReadLine());
                        for (int i = jour; i <= tmp; i++)
                        {
                            if (maFourmiliere.updateJournalier())
                            {
                                maFourmiliere.checkAge();
                            }
                            else if(!mort)
                            {
                                jourMort = i;
                                mort = true;
                            }
                        }
                        if (mort)
                        {
                            jour = jourMort;
                        } else {
                            jour = tmp;
                        }
                        
                        break;
                    case "q":
                        break;
                    default:
                        ++jour;
                        if (maFourmiliere.updateJournalier()) { }
                        else { mort = true; }
                        maFourmiliere.checkAge();
                        break;
                }
            } while (commande != "q" && !mort);

            Console.WriteLine($"            **        La foumilière est morte au jour {jour}!       **");

            Console.ReadKey();    
        }

        public static void rapportJournalier(Fourmiliere maFourmiliere, int jour)
        {
            int nbReine = 0;
            int nbLarve = 0;
            int nbOuvriere = 0;
            int nbMale = 0;
            foreach (Fourmi fourmi in maFourmiliere.ListFourmi)
            {
                if (fourmi is Reine)
                {
                    ++nbReine;
                }
                else if (fourmi is Ouvriere)
                {
                    ++nbOuvriere;
                }
                else if (fourmi is Male)
                {
                    ++nbMale;
                }
                else if (fourmi is Larve)
                {
                    ++nbLarve;
                }
            }
            var nbTot = nbReine + nbOuvriere + nbMale + nbLarve;
            Console.WriteLine($"La fourmilière comprend au jour {jour} une population de {nbTot} fourmis, soit:\n {nbReine} Reines \n {nbMale} Mâles \n {nbOuvriere} Ouvrières \n {nbLarve} Larves");
        }

        public static void getTrolled() {

            Console.Clear();
            affichageDeBatardTempo();
            
            System.Threading.Thread.Sleep(200);

            for (int i =0; i <= 7; i++) {
                Console.Clear();
                affichageDeBatard();
                System.Threading.Thread.Sleep(200);
            }
            
            Console.ReadKey();
        }

        public static void affichageDeBatard() {
            System.Threading.Thread.Sleep(200);
            Console.WriteLine("             /´¯/) ");


            Console.WriteLine("            /    // ");


            Console.WriteLine("         ../    // ");


            Console.WriteLine("     /´¯/    /´¯\\ ");


            Console.WriteLine(" /¯/   /    /    / |_ ");


            Console.WriteLine("( (    (    (    / )´¯) ");


            Console.WriteLine(" \\                \\/   / ");


            Console.WriteLine("  \\                  / ");


            Console.WriteLine("    \\              ( ");


            Console.WriteLine("      \\             \\   ");

        }

        public static void affichageDeBatardTempo() {
            Console.WriteLine("............./´¯/) ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("............/....// ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine(".........../....// ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("...../´¯/..../´¯\\ ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("./¯/.../..../..../.|_ ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("(.(....(....(..../.)´¯) ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine(".\\................\\/.../ ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("..\\................. / ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("....\\..............( ");
            System.Threading.Thread.Sleep(200);

            Console.WriteLine("......\\.............\\...");
        }

      
    }
}
