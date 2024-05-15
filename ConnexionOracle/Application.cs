using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionOracle
{
    internal class Application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début de connexion...");
            string connectionString = "User Id=C##taskforce;Password=C##taskforce;Data Source=localhost:1521/ORCL";
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    // Ouvrir la connexion
                    conn.Open();
                    Console.WriteLine("Connexion réussie!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erreur: {ex.Message}");
                }
            }
        }
    }
}
