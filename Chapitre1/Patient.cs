using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class Patient
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Cin { get; set; }

        // Surcharge de constructeur (overloading)
        public Patient() { }

        public Patient(string nom, string prenom, int cin)
        {
            Nom = nom;
            Prenom = prenom;
            Cin = cin;
        }
        public string info()
        {
            return "Nom : " + Nom + ", Prenom : " + Prenom + ", Cin : " + Cin;
        }

    }
}
