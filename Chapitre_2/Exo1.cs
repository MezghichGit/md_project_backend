using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre_2
{
    internal class Exo1
    {
        public static void Main(String[] args)
        {
            EtudiantEmployer ee1 = new EtudiantEmployer
            {
                Nom = "Mohamed Salah",
                Age = 30,
                Poids = 80.5

            };

            Console.WriteLine(ee1);

            EtudiantEmployer ee2 = new EtudiantEmployer
            {
                Nom = "Mohamed Salah",
                Age = 30,
                Poids = 80.5

            };
            Console.WriteLine(ee2);
        }
    }
}
