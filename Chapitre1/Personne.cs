using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class Personne
    {
        public string Nom {  get; set; }
        public int Age { get; set; }

        public Personne() { }

        public Personne(string nom, int age) {
            Nom = nom;
            Age = age;
        }
        public Personne(string nom) {
            Nom = nom;
        }

        public override string ToString()
        {
            return "Nom : "+Nom +" Age : "+Age;
        }

    }
}
