using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class TestVoiture
    {
        static void Main(string[] args)
        {
            // Création d'une liste de voitures
            List<Voiture> voitures = new List<Voiture>
            {
                new Voiture("Peugeot", 15000,100000),
                new Voiture("Renault", 18000,120000),
                new Voiture("Citroen", 20000,160000)
            };

            // Affichage des informations de chaque voiture
            foreach (Voiture voiture in voitures)
            {
                Console.WriteLine("Marque : " + voiture.Marque + ", Prix : " + voiture.Prix + " EUR"+ " KM : "+voiture.getKilometrage());
            }

            Console.ReadKey();
        }

    }
}
