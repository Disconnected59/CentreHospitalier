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


        //Fonction de connexion
        private static bool seConnecter()
        {
            if (laConnection == null)
            {
                laConnection = new SqlConnection();
                laConnection.ConnectionString = "Data Source=WIN-921C8FKTGAE;Initial Catalog=slam2019HopitalPharmacieLecompte;User ID=lecompte;Password=lecompte";
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


        //Fonction de déconnexion
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






    }
}
