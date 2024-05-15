using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionOracle
{
    public class ServeurAPI  //Singleton
    {
        private ServeurAPI() {
            Console.WriteLine("Constrcution du Singleton");
        }
        private static ServeurAPI instance=null;

        public static ServeurAPI getInstance() {

            if (instance == null)
            {
                instance = new ServeurAPI();
            }
            return instance;
        }
    }


    public class Test { 
    public static void Main(string[]args) {

            ServeurAPI s1 = ServeurAPI.getInstance();
            ServeurAPI s2 = ServeurAPI.getInstance();

        }
    }
}
