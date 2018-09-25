using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationResponsables
{
    class Passerelle
    {
        //Quentin Lecompte le 11/09/2018
        private static SqlConnection laConnection = null;


        // ----- Fonction de connexion ------
        private static bool seConnecter() // Include la fonction pour se connecter a la BDD //Créer la commande avec la variable laConnection
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source=WIN-921C8FKTGAE;Initial Catalog=slam2019BearezPpeBearez;User ID=bearez;Password=bearez";
                //laConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=slam2019HopitalPharmacie;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                laConnection.Open();
                System.Diagnostics.Debug.WriteLine("instanciation connexion");

            }
            else
            {
                System.Diagnostics.Debug.WriteLine("connexion existe");

            }
            return true;

        }


        // ----- Fonction de déconnexion -----
        public static bool seDeconnecter()
        {
            if (laConnection != null)
            {
                laConnection.Close();
                System.Diagnostics.Debug.WriteLine("déconnexion");
                laConnection = null;

            }
            return true;
        }


        // ----- Fonction récupérant la capacité d'accueil maximale du service -----
        public static bool recupCapacitéMax(String pService)
        {
            bool verif=false;


            return verif;
        }


        public static ArrayList getPatients() //Lecompte 18/09/2018 v1.0
        {
            ArrayList lesPatients = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT nom FROM Patients";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();

            while (unJeuResultat.Read())
            {
                String lePatient = (String)unJeuResultat["nom"];
                lesPatients.Add(lePatient);

            }
            seDeconnecter();
            return lesPatients;


        }

        public static ArrayList getServices() //Lecompte 18/09/2018 v1.0
        {
            ArrayList lesServices = new ArrayList();
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT libelle FROM Services";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                String leService = (String)unJeuResultat["libelle"];
                lesServices.Add(leService);

            }
            seDeconnecter();
            return lesServices;

        }

        public static void changerDateDebutHospitalisation(DateTime pDateDebut) //Lecompte 18/09/2018 v1.0
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "UPDATE Patients set dateArrivee='" + pDateDebut + "'";
            maCommande = new SqlCommand(requete, laConnection);
            Int32 nb = maCommande.ExecuteNonQuery();
            seDeconnecter();
        }

        public static void changerDateFinHospitalisation(DateTime pDateFin) //Lecompte 18/09/2018 v1.0
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "UPDATE Patients set dateDepart='" + pDateFin + "'";
            maCommande = new SqlCommand(requete, laConnection);
            Int32 nb = maCommande.ExecuteNonQuery();
            seDeconnecter();

        }


        public static void getTauxOccuMois(String pService, int pMois)
        {





        }

<<<<<<< HEAD
        // ----- Fonction de connexion utilisateur IHM ------
        public bool connexionIhm()
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT id, password, typeUtilisateur FROM Utilisateur";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                
            }
            return false;
        }
=======
>>>>>>> 6f98f6cfea75126356c2924c5f23abcd64a23025

    }
}
