using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class Etudiant:Personne
    {
        public int NumInscription { get; set; }

        public Etudiant(string nom, int age, int numins) : base(nom, age)
        { 
            NumInscription = numins;
        }

        public override string ToString()
        {
            return base.ToString()+" NumInscription : "+NumInscription;
        }

    }
}
