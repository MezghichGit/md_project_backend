using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre3
{
    public class LesExceptions
    {
        public static void saisieData() {

            // saisie du nom
            Console.WriteLine("Donner votre nom : ");
            try
            {
                string nom = Console.ReadLine();
                if (nom.Length < 5)
                {
                    throw new ArgumentException("Nom invalide, nombre de caractères doit être >=5");
                }
            }
            catch (ArgumentException e) { 
                Console.WriteLine(e.Message);
            }


            // saisie du cin

            Console.WriteLine("Donner votre CIN: ");
            try
            {
                string cin = Console.ReadLine();
                int cinNumerique;
                bool isCinNumber = int.TryParse(cin, out cinNumerique);

                if (!isCinNumber)
                {
                    throw new ArgumentException("CIN invalide, doit être numérique");
                }
                else {
                    if (cin.Length != 8)
                    {
                        throw new ArgumentException("CIN invalide, doit avoir une taille de 8");
                    }
                    else Console.WriteLine("CIN valide : {0} ", cinNumerique);

                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void saisieAge(int age)
        {
            if (age < 15)
                throw new ArgumentException("Age est invalide");
            else
                Console.WriteLine("Bienvenue à TaskForce");
        }
        public static void Main(String[] args)
        {
            saisieData();
            /*

            decimal x = 10;
            decimal y = 10;
            */



            /* try
             {
                 //Console.WriteLine("x/y = {0}", (x / y));
                 //int[] tab = { 10, 20 };
                 //Console.WriteLine("tab[2] = {0}", tab[2]);
                // saisieAge(12);
             }
             catch (ArgumentException e)
             {
                 Console.WriteLine("Problème : {0}", e.Message);
             }
             catch (ArithmeticException e)
             {
                 Console.WriteLine("Problème de calcul : {0}", e.Message);
                 Console.WriteLine(e.StackTrace);
             }
             catch (Exception e)
             {
                 Console.WriteLine("Exception générale : {0}", e.Message);
                 Console.WriteLine(e.StackTrace);
             }
             Console.WriteLine("Suite du programme...");*/
        }
    }
}
