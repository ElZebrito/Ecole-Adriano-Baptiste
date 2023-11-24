using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sicily.DAL;
using Sicily.Modele;


namespace Sicily.Controleur
{
    public class Mgr
    {

        SicilyDAO SicDAO = new SicilyDAO();

        List<Secteur> maListeSecteur;
        List<Liaison> maListeLiaison;

        public Mgr()
        {

            maListeSecteur = new List<Secteur>();

            maListeLiaison = new List<Liaison>();
        }



        // Récupération de la liste des secteurs à partir de la DAL
        public List<Secteur> chargementSicBD()
        {

            maListeSecteur = SicilyDAO.getSecteurs();

            return (maListeSecteur);
        }

        public List<Liaison> chargementLiaiBD()
        {

            maListeLiaison = SicilyDAO.getLiaisons();

            return (maListeLiaison);
        }
        public void SupLiaison(Liaison liaison)
        {
            SicilyDAO.SupLiaison(liaison);
           
        }
        public void ModifDurer(Liaison liaison, string Duree)
        {
            SicilyDAO.ModifDurer(liaison,Duree);

        }

        public void InsererNouvelleLiaison(int idliaison, int idSecteur, int idPortDepart, int idPortArrivee, string duree)
        {
            Liaison nouvelleLiaison = new Liaison(idliaison, idSecteur, idPortDepart, idPortArrivee, TimeSpan.Parse(duree));
            SicilyDAO.InsertLiaison(nouvelleLiaison);
           
           
        }
    }
}