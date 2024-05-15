using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre_2
{
    class Cours {
        public string Nom { get; set; }
    }

    internal class PassageParametres
    {
        public static void permut(ref int a, ref int b, out int somme)
        {
                        Console.WriteLine(" a = {0}, b = {1}", a, b);
            int aux = a;
            a = b;
            b = aux;
            somme = a+b;
            Console.WriteLine(" a = {0}, b = {1}", a, b);
        }

        public static void changeCours(Cours cours)
        {
            cours.Nom = "C#";
        }
        public static void Main(string[] args) {
           
            /*Cours c1 = new Cours();
            c1.Nom = "Angular";
            Console.WriteLine(" c1.Nom = {0}", c1.Nom);
            changeCours(c1);
            Console.WriteLine(" c1.Nom = {0}", c1.Nom);*/

            
             int x = 1;
             int y = 2;
             Console.WriteLine(" x = {0}, y = {1}",x,y);
             int res;
             permut(ref x, ref y, out res);
             Console.WriteLine(" x = {0}, y = {1}",x,y);
            Console.WriteLine(" res = {0}", res);

        }
    }
}
