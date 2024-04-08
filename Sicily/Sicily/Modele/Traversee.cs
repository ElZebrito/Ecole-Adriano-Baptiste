using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily.Modele
{
    public class Traversee
    {
        private int ID_TRAVERSEE;
        private int ID_LIAISON;
        private int ID_BATEAU;

        // remplace getId()
        public int IdTr { get => ID_TRAVERSEE; }
        public int IdLi { get => ID_LIAISON; }

        public int IdBat { get => ID_BATEAU; }


        public Traversee(int IdTr, int IdLi, int IdBat)
        {
            this.ID_TRAVERSEE = IdTr;
            this.ID_LIAISON = IdLi;
            this.ID_BATEAU = IdBat;

        }





        // pour afficher la liste par la suite
        public string DescriptionTraversee
        {
            get => "Id Traversee : " + this.ID_TRAVERSEE + " IdLiaison : " + this.ID_LIAISON + " Numéro Bateau : "+this.ID_BATEAU;
        }


    }
}
