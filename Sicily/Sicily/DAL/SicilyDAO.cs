using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sicily.Modele;
using System.Security.Principal;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;

namespace Sicily.DAL
{
    public class SicilyDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicily";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


       

        // Récupération de la liste des Secteur
        public static List<Secteur> getSecteurs()
        {

            List<Secteur> lc = new List<Secteur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;




                while (reader.Read())
                {

                    int ID_SECTEUR = (int)reader.GetValue(0);
                    string LIBELLE_SECTEUR = (string)reader.GetValue(1);
                   

                    //Instanciation d'un Secteur
                    s = new Secteur(ID_SECTEUR, LIBELLE_SECTEUR);

                    // Ajout de ce secteur à la liste 
                    lc.Add(s);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}
