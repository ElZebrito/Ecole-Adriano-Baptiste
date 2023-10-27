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

    }
}