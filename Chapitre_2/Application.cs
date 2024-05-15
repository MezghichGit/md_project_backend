using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre_2
{
    internal class Application
    {
        public static void Main(String[] args) {
            Circle c = new Circle(); //constructeur par défaut

            Multifonction imp = new Multifonction();
            imp.imprimer();
            imp.photocopier();
            imp.scanner();


            /*Voiture.VitesseMax = 240;
            Voiture.getVitesseMax();

            Voiture v1 = new Voiture();
            v1.Marque = "BWM";
            v1.Modele = "X5";
            //v1.VitesseMax = 280;

            Voiture v2 = new Voiture();
            v2.Marque = "Mercedes";
            v2.Modele = "GLA";*/

        }
    }
}
