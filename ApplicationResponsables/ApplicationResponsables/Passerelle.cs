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
    public class Passerelle
    {
        //Quentin Lecompte le 11/09/2018
        private static SqlConnection laConnection = null;


        // ----- Fonction de connexion ------
        private static bool seConnecter() // Include la fonction pour se connecter a la BDD //Créer la commande avec la variable laConnection
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source=WIN-921C8FKTGAE;Initial Catalog=slam2019TableauDeBordABL;User ID=lecompte;Password=lecompte";
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
        public static int recupCapacitéMax(int pService) //Lecompte 02/10/18
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT capacite FROM Services WHERE id='" + pService + "'";
            maCommande = new SqlCommand(requete, laConnection);
            int Resultat = (int)maCommande.ExecuteScalar();
             seDeconnecter();
            return Resultat;
           


        }

        public static int capaciteMaxHopital() //Lecompte 04/10/18
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT SUM capacite FROM Services";
            maCommande = new SqlCommand(requete, laConnection);
            int Resultat = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return Resultat;
        }


      public static int nbOccupantsServiceParPeriode(DateTime pDebutPeriode, DateTime pFinPeriode, int pService) //Lecompte 02/10/18
      {
          int Resultat;
          seConnecter();
          SqlCommand maCommande;
          String requete = "SELECT COUNT(*) FROM Patients WHERE numeroService='"+pService+"' AND dateArrivee BETWEEN '"+pDebutPeriode+"' AND '"+pFinPeriode+"'";
          maCommande = new SqlCommand(requete,laConnection);
          Resultat=(int)maCommande.ExecuteScalar();
          seDeconnecter();
          return Resultat;


      }

    public static int nbOcuppantsServiceParMois(int pMois, int pService) //Lecompte 04/10/18
      {
          seConnecter();
          SqlCommand maCommande;
        String requete = "";
        if(pMois!=2)
        {
            requete = "SELECT COUNT(*) FROM Patiens WHERE numeroService='" + pService + "' AND dateArrivee BETWEEN '01/" + pMois + "/18 AND '31/" + pMois + "/18";
        }
        else
        {
            requete = "SELECT COUNT(*) FROM Patiens WHERE numeroService='" + pService + "' AND dateArrivee BETWEEN '01/" + pMois + "/18 AND '29/" + pMois + "/18";

        }
        maCommande = new SqlCommand(requete, laConnection);
        int Resultat = (int)maCommande.ExecuteScalar();
        seDeconnecter();
        return Resultat;

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

        // ----- Fonction de connexion utilisateur IHM ------
        public static bool connexionIhm(string id, string mdp) //Bekir 25/09/2018 v0.1
        {
            bool test = false;
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT id, password FROM Utilisateurs";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                string idBdd = (string)unJeuResultat["id"];
                string mdpBdd = (string)unJeuResultat["password"];
                if(id == idBdd && mdp == mdpBdd)
                {
                    test = true;
                }
            }
            seDeconnecter();
            return test;
        }


        public static Double tauxOccupationPeriodeService(DateTime pDebutPeriode, DateTime pFinPeriode, int pService)// Lecompte 02/10/18
        {
            Double taux = 0;
            int nbOccu = Passerelle.nbOccupantsServiceParPeriode(pDebutPeriode, pFinPeriode, pService);
            if (nbOccu != 0)
            {
                int nbOccuMaxService = Passerelle.recupCapacitéMax(pService);
                taux = nbOccuMaxService / nbOccu;
                Math.Round(taux, 2);
            }

            return taux;


        }

        public static Double tauxOccuMoisService(int pMois, int pService)
        {
            int nbOccuMois = Passerelle.nbOcuppantsServiceParMois(pMois, pService);
            int nbPlacesService = Passerelle.recupCapacitéMax(pService);

            Double taux = nbOccuMois / nbPlacesService;
            return taux;


        }



    }
}
