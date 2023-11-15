using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily.Modele
{
    public class Liaison
    {
        private int ID_LIAISON;
        private int ID_SECTEUR;
        private int ID_PORT;
        private int ID_PORT_ARRIVEE;
        private string DUREE_LIAISON;
        private TimeSpan dUREE_LIAISON;






        // remplace getId()
        public int IdLiaison { get => ID_LIAISON; }
        public int IdSecteur { get => ID_SECTEUR; }
        public int IdPortDepart { get => ID_PORT; }
        public int IdPortArrivee { get => ID_PORT_ARRIVEE; }
        public string Duree { get => DUREE_LIAISON; set => DUREE_LIAISON = value; }
        //public Secteur Secteur { get => secteur; }


        // public Liaison(int unIdL, int unIdS, int unIdPort, int unIdPortArrivee, string UneDuree)
        // {
        //    this.ID_LIAISON = unIdL;
        //   this.ID_SECTEUR = unIdS;
        //  this.ID_PORT = unIdPort;
        // this.ID_PORT_ARRIVEE = unIdPortArrivee;
        //this.DUREE_LIAISON = UneDuree;

        //}

        public Liaison(int iD_LIAISON, int iD_SECTEUR, int iD_PORT, int iD_PORT_ARRIVEE, TimeSpan dUREE_LIAISON)
        {
            ID_LIAISON = iD_LIAISON;
            ID_SECTEUR = iD_SECTEUR;
            ID_PORT = iD_PORT;
            ID_PORT_ARRIVEE = iD_PORT_ARRIVEE;
            this.dUREE_LIAISON = dUREE_LIAISON;
            DUREE_LIAISON = dUREE_LIAISON.ToString();
        }



        // Constructeur vide


        // pour afficher la liste par la suite
        public string DescriptionLIAISON
        {
            get => "IdL : " + this.ID_LIAISON + " IdS :" + this.ID_SECTEUR + " IdPortDepart :" + this.ID_PORT + " IdPortArrivee :" + this.ID_PORT_ARRIVEE + " Duree :" + this.DUREE_LIAISON;
        }

    }
}