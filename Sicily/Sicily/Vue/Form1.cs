using Sicily.Controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sicily.Modele;
using Sicily.DAL;

namespace Sicily
{
    public partial class Form1 : Form
    {
        Mgr monManager;

        List<Secteur> lSec = new List<Secteur>();
        List<Liaison> lLiai= new List<Liaison>();
        List<Liaison> ListeLiaisonParSecteur ;
        public Form1()
        {
            InitializeComponent();

            monManager= new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxliaison.Visible = true;
            textBox1.Visible = true;

            lSec = monManager.chargementSicBD();
            lLiai = monManager.chargementLiaiBD();

            affiche();
        }

        public void affiche()

        {


            try
            {


                listBoxSecteur.DataSource = null;
                listBoxSecteur.DataSource = lSec;
                listBoxSecteur.DisplayMember = "DescriptionSecteur";

                Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
                ListeLiaisonParSecteur = SicilyDAO.TrouverLiaison(secteur, lLiai);


                listBoxliaison.DataSource = ListeLiaisonParSecteur;
                listBoxliaison.DisplayMember = "DescriptionLiaison";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        //ListBox Secteur

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            affiche();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Insertion_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxliaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
