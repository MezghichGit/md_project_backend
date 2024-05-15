using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre_2
{
    public class EtudiantEmployer : Etudiant, Employer
    {

        public string Nom
        {
            get;
            set;
           
        }

        public int Age
        {
            get;
            set;
            
        }

        public double Poids
        {
            get;
            set;
          
        }

        public void affiliationCnss()
        {
            Console.WriteLine("Inscrit CNSS");
        }

        public void getMoyenne()
        {
            Console.WriteLine("Très bonne moyenne");
        }

        public void getNumInscription()
        {
            Console.WriteLine("Inscription Num : 1234");
        }

        public void salaire()
        {
            Console.WriteLine("Salaire ");
        }

        public override string ToString()
        {
            return "Nom : " + Nom + " Age : " + Age+" Poids : "+Poids;
        }
    }
}