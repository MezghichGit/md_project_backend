using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class TestPersonne
    {
        public static void Main(string[] args) { 
         Personne personne = new Personne("Amine",38);
            //Console.WriteLine(personne.ToString());
            Console.WriteLine(personne);
            Etudiant etudiant = new Etudiant("Amine",38,123);
            Console.WriteLine(etudiant);
        }
    }
}
