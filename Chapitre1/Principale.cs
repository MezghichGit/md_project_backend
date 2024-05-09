using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    public class Principale
    {
        static void Main(string[] args)
        {
            // Demander à l'utilisateur de saisir son nom
            Console.WriteLine("Entrez votre prenom :");
            string prenom = Console.ReadLine();

            Console.WriteLine("Entrez votre nom :");
            string nom = Console.ReadLine();

            Console.WriteLine("Entrez votre age :");
            int age = int.Parse(Console.ReadLine());


            // Afficher un message de bienvenue
            //Console.WriteLine("Bonjour, " + nom + "!");
            Console.WriteLine("Bonjour, {1} {0} {2}",nom, prenom,age);
        }

    }
}
