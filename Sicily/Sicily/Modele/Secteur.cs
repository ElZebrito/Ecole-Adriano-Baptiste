using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily.Modele
{
    public class Secteur
    {
        private int ID_SECTEUR;
        private string LIBELLE_SECTEUR;





        // remplace getId()
        public int Id { get => ID_SECTEUR; }
        public string Libelle { get => LIBELLE_SECTEUR; }


        public Secteur(int unId, string unLibelle)
        {
            this.ID_SECTEUR = unId;
            this.LIBELLE_SECTEUR = unLibelle;
            
        }


        // Constructeur vide


        // pour afficher la liste par la suite
        public string DescriptionSecteur
        {
            get => "Id : " + this.ID_SECTEUR + " Libelle :" + this.LIBELLE_SECTEUR ;
        }
        
        
    }
}