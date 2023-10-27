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
        private static MySqlCommand Ocom2;




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

        public static List<Liaison> getLiaisons()
        {

            List<Liaison> ll = new List<Liaison>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom2 = maConnexionSql.reqExec("Select * from liaison");


                MySqlDataReader reader = Ocom2.ExecuteReader();

                Liaison l;




                while (reader.Read())
                {

                    int ID_LIAISON = (int)reader.GetValue(0);
                    int ID_SECTEUR = (int)reader.GetValue(1);
                    int ID_PORT = (int)reader.GetValue(2);
                    int ID_PORT_ARRIVEE = (int)reader.GetValue(3);
                    int DUREE_LIAISON = (int)reader.GetValue(4);


                    //Instanciation d'un Secteur
                    l = new Liaison(ID_LIAISON, ID_SECTEUR, ID_PORT, ID_PORT_ARRIVEE, DUREE_LIAISON);

                    // Ajout de ce secteur à la liste 
                    ll.Add(l);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (ll);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }

    }




}
