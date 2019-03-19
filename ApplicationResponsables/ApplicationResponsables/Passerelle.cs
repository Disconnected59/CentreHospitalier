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

        public static ArrayList getAnnees() //Lecompte 09/11/18
        {
            seConnecter();
            ArrayList lesAnnees= new ArrayList();
            int annee;
            SqlCommand maCommande;
            String requete = "SELECT DISTINCT AnnéeSejour FROM Sejours";
            maCommande = new SqlCommand(requete, laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                annee = (int)unJeuResultat["AnnéeSejour"];
                lesAnnees.Add(annee);
            }
            seDeconnecter();
            return lesAnnees;
            


        }

        public static int capaciteMaxHopital() //Lecompte 04/10/18
        {
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT SUM(capacite) FROM Services";
            maCommande = new SqlCommand(requete, laConnection);
            int Resultat = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return Resultat;
        }


      public static ArrayList SejoursServiceParPeriode(int pMoisDebut, int pMoisFin, int pService, int pAnnee) //Lecompte 09/10/18
      {
          ArrayList lesSejours = new ArrayList();
          int id; String moisSejour; int annee; int nbPatient; int idService; int dureeMoy;
          seConnecter();
          SqlCommand maCommande;
          String requete = "SELECT * FROM Sejours WHERE idService = "+pService+" AND id BETWEEN "+pMoisDebut+"AND "+pMoisFin+" AND AnnéeSejour="+pAnnee;
          maCommande = new SqlCommand(requete,laConnection);
            SqlDataReader unJeuResultat = maCommande.ExecuteReader();
            while (unJeuResultat.Read())
            {
                id = (int)unJeuResultat["id"];
                moisSejour = (string)unJeuResultat["MoisSejour"];
                annee = (int)unJeuResultat["AnnéeSejour"];
                nbPatient = (int)unJeuResultat["nbPatients"];
                idService = (int)unJeuResultat["idService"];
                dureeMoy = (int)unJeuResultat["dureeMoyenne"];

                Sejour unSejour = new Sejour(id, moisSejour, annee, nbPatient, idService, dureeMoy);
                lesSejours.Add(unSejour);
            }
            seDeconnecter();
            return lesSejours;
          
          


      }

    public static int nbOcuppantsServiceParMois(int pMois, int pService) //Lecompte 04/10/18
      {
          seConnecter();
          SqlCommand maCommande;
        String requete = "SELECT nbPatients FROM Sejours WHERE id="+pMois;                
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
        public static bool WebRequestTest()
        {
            string url = "http://www.google.com";
            try
            {
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();
            }
            catch (System.Net.WebException)
            {
                return false;
            }
            return true;
        }
        public static Double tauxOccuMoisService(int pMois, int pService) //Lecompte 16/10/18
        {
            int nbOccuMois = Passerelle.nbOcuppantsServiceParMois(pMois, pService);
            int nbPlacesService = Passerelle.recupCapacitéMax(pService);

            Double taux = (nbOccuMois*100 / nbPlacesService);
            return taux;


        }

       


        public static int getOccupantsHopitalParMois(int pMois, int pAnnee) //Lecompte 09/11/18
        {
            int nbOccupants = 0;
            seConnecter();
            SqlCommand maCommande;
            String requete = "SELECT SUM(nbPatients) FROM Sejours WHERE id=" + pMois + " AND AnnéeSejour ="+pAnnee;
            maCommande = new SqlCommand(requete, laConnection);
            nbOccupants = (int)maCommande.ExecuteScalar();
            seDeconnecter();
            return nbOccupants;
        }

        public static Double tauxOccupationParMois(int pMois, int pAnnee)
        {
            Double taux = 0;
            seConnecter();
            int capaMax = Passerelle.capaciteMaxHopital();
            taux = Passerelle.getOccupantsHopitalParMois(pMois, pAnnee)*100 / capaMax;
            return taux;
        }




    }
}
