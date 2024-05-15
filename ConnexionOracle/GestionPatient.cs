using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnexionOracle
{
    internal class GestionPatient
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

                    // Ajouter deux nouvelles lignes à la table Patient
                    string insertSql1 = "INSERT INTO PATIENT (NOM,CIN,OBSERVATION) VALUES ('Amir',02365897,'Obs1')";
                    string insertSql2 = "INSERT INTO PATIENT (NOM,CIN,OBSERVATION) VALUES ('HALIM',05241587,'Obs2')";


                    //Ajout d'un enregistrement
                    using (OracleCommand cmd = new OracleCommand(insertSql1, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Première ligne ajoutée.");
                    }
                    //Ajout d'un enregistrement

                    using (OracleCommand cmd = new OracleCommand(insertSql2, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Deuxième ligne ajoutée.");
                    }

                    
                    //Suppression d'un enregistrement
                    string deleteSql1 = "delete from PATIENT where CIN=02365897";

                    using (OracleCommand cmd = new OracleCommand(deleteSql1, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("ligne supprimé.");
                    }
                    //Update d'un enregistrement
                    string updateSql1 = "update  PATIENT set NOM='HALIMA' where CIN=05241587";

                    using (OracleCommand cmd = new OracleCommand(updateSql1, conn))
                    {
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("Mise à jour avec succès.");
                    }

                    // Définir la commande SQL pour lire toutes les lignes
                    string selectSql = "SELECT * FROM PATIENT";

                    // Créer une commande Oracle pour lire les données
                    using (OracleCommand cmd = new OracleCommand(selectSql, conn))
                    {
                        // Exécuter la commande
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            // Lire et afficher les données
                            while (reader.Read())
                            {
                                int ID = reader.GetInt32(0);
                                string NOM = reader.GetString(1);
                                int CIN = reader.GetInt32(2);
                                string OBS = reader.GetString(3);

                                Console.WriteLine($"ID: {ID},Nom: {NOM}, Cin: {CIN}, Observation: {OBS}");
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
}
