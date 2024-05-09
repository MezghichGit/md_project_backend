using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class DemoType
    {

       /*
        struct Point
        {
            public int Abcisse;
            public int Ordonné;
            public Point(int x, int y)
            {
                Abcisse = x;
                Ordonné = y;
            }
        }*/
        static void Main(string[] args)
        {
            Point P1 = new Point(1, 2);
            Point P2;
            P2 = P1;
            Console.WriteLine("coord. du point P1 =({0},{1})", P1.Abcisse, P1.Ordonné);
            Console.WriteLine("coord. du point P2 =({0},{1})", P2.Abcisse, P2.Ordonné);
            Console.WriteLine("---");
            Console.WriteLine("modification du Point P2");
            P2.Abcisse = 0;
            Console.WriteLine("coord. du point P1 =({0},{1})", P1.Abcisse, P1.Ordonné);
            Console.WriteLine("coord. du point P2 =({0},{1})", P2.Abcisse, P2.Ordonné);
            Console.ReadKey();
        }


    }
}
