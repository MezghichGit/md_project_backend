using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class Voiture
    {
        public string Marque { get; set; }
        public double Prix { get; set; }
        private int kilometrage;
        
        public int getKilometrage() {
            return this.kilometrage;
        }

        public void setKilometrage(int km)
        {
            this.kilometrage=km;
        }

        // Constructeur de la classe Voiture
        public Voiture(string marque, double prix, int km)
        {
            Marque = marque;
            Prix = prix;
            setKilometrage(km);
        }

    }
}
