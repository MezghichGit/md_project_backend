using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chapitre1
{
    internal class MainPatient
    {
        public static Patient saisiePatient() {

            Console.WriteLine("****** Saisie des infos d'un patient : *******");


            Patient patient = new Patient();

            Console.WriteLine("Entrez prenom patient :");
            patient.Prenom = Console.ReadLine();

            Console.WriteLine("Entrez nom patient :");
            patient.Nom = Console.ReadLine();

            Console.WriteLine("Entrez cin patient :");
            patient.Cin = int.Parse(Console.ReadLine());

            return patient;

        }
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();

            for (int i = 0; i < 3; i++) {
                Patient patient = saisiePatient();
                patients.Add(patient);
            }

            //Patient p1 = saisiePatient();
            //Patient p2 = saisiePatient();

            //List<Patient> patients = new List<Patient> {p1,p2 };
            
            // Affichage des informations de chaque voiture
            foreach (Patient patient  in patients)
            {
                Console.WriteLine(patient.info());
            }
        }
    }
}
