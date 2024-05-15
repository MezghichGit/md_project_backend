using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre_2
{
    public class Voiture
    {
        public static double VitesseMax { get; set; }

        public static void getVitesseMax() {
            Console.WriteLine(VitesseMax);
        }
        public Voiture()
        {
            
        }

        public Voiture(string marque, string modele)
        {
            Marque = marque;
            Modele = modele;
        }

        public string Marque
        {
            get => default;
            set
            {
            }
        }

        public string Modele
        {
            get => default;
            set
            {
            }
        }
    }
}