using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class ConversionTypes
    {
        public static void Main(String[] args) {

          


            short z = 257; // il dépasse de 1 le max de byte[0 255]
            byte x = (byte)z;
            Console.WriteLine("x = {0}",x);
        }
    }
}
