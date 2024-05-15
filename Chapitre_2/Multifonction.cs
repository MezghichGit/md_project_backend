using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapitre_2
{
    public class Multifonction : Photocopieuse, Imprimante, Scanner
    {
        public void imprimer()
        {
            Console.WriteLine("Impression en cours");
        }

        public void photocopier()
        {
            Console.WriteLine("Photocopie en cours");
        }

        public void scanner()
        {
            Console.WriteLine("Scan en cours");
        }
    }
}