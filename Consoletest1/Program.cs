using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

class Program
{
    static void Main(string[] args)
    {
        // Chaîne de connexion Oracle
        string connectionString = "User Id=C##taskforce;Password=C##taskforce;Data Source=localhost:1521/ORCL";

        // Créer une connexion
        using (OracleConnection conn = new OracleConnection(connectionString))
        {
            try
            {
                // Ouvrir la connexion
                conn.Open();
                Console.WriteLine("Connexion réussie!");

                // Ajouter deux nouvelles lignes à la table PRODUIT
                string insertSql1 = "INSERT INTO PRODUIT (LIBELLE,PRIX,QUANTITE) VALUES ('Produit x', 10,2)";
                string insertSql2 = "INSERT INTO PRODUIT (LIBELLE,PRIX,QUANTITE) VALUES ('Produit y', 20,3)";

                using (OracleCommand cmd = new OracleCommand(insertSql1, conn))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Première ligne ajoutée.");
                }

                using (OracleCommand cmd = new OracleCommand(insertSql2, conn))
                {
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deuxième ligne ajoutée.");
                }

                // Définir la commande SQL pour lire toutes les lignes
                string selectSql = "SELECT * FROM PRODUIT";

                // Créer une commande Oracle pour lire les données
                using (OracleCommand cmd = new OracleCommand(selectSql, conn))
                {
                    // Exécuter la commande
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        // Lire et afficher les données
                        while (reader.Read())
                        {
                            string libelle = reader.GetString(1);
                            decimal prix = reader.GetDecimal(2);
                            int qte = reader.GetInt32(3);

                            Console.WriteLine($"Libelle: {libelle}, Prix: {prix}, Qte: {qte}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");
            }
        }

        Console.WriteLine("Appuyez sur une touche pour fermer...");
        Console.ReadKey();
    }
}
