using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class Point
    {
        public int Abcisse;
        public int Ordonné;
        public Point(int x, int y)
        {
            Abcisse = x;
            Ordonné = y;
        }

       
        public override string ToString()
        {
            return Abcisse + " " + Ordonné;
        }

    }
}
