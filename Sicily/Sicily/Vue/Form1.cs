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
using Sicily.Vue;

namespace Sicily
{
    public partial class Form1 : Form
    {
        Mgr monManager;

        List<Secteur> lSec = new List<Secteur>();
        List<Liaison> lLiai= new List<Liaison>();
        List<Traversee> lTraver = new List<Traversee>();
        List<Liaison> ListeLiaisonParSecteur ;
        List<Traversee> lTraversee;
        public Form1()
        {
            InitializeComponent();


            monManager= new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxliaison.Visible = true;
            tbLiaison.Visible = true;

            lSec = monManager.chargementSicBD();
            lLiai = monManager.chargementLiaiBD();
            lTraver = monManager.chargementTraversee();
            listBoxSecteur.ClearSelected();
            listBoxliaison.ClearSelected();



            affiche();
        }
        public void RefreshForm()
        {
            listBoxliaison.DataSource = null;
            listBoxliaison.DataSource = ListeLiaisonParSecteur;
            listBoxliaison.DisplayMember = "DescriptionLiaison";
        }
        public void affiche()

        {


            /*  try
              {



                  listBoxSecteur.DataSource = lSec;
                  listBoxSecteur.DisplayMember = "DescriptionSecteur";
                  listBoxliaison.DataSource = ListeLiaisonParSecteur;
                  listBoxliaison.DisplayMember = "DescriptionLiaison";


              }


              catch (Exception ex)
              {

                  MessageBox.Show(ex.Message);
              }*/
            try
            {

                listBoxSecteur.DataSource = lSec;
                listBoxSecteur.DisplayMember = "DescriptionSecteur";

                // Mettre à jour ListeLiaisonParSecteur en fonction de la sélection actuelle
                Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
                ListeLiaisonParSecteur = SicilyDAO.TrouverLiaison(secteur, lLiai);

                listBoxliaison.DataSource = null;  // Supprimer la source de données existante
                listBoxliaison.DataSource = ListeLiaisonParSecteur;  // Assigner la nouvelle liste
                listBoxliaison.DisplayMember = "DescriptionLiaison";
                

                Liaison liaison = listBoxliaison.SelectedItem as Liaison;
                lTraversee = SicilyDAO.TrouverTraversee(liaison, lTraver);


                
                listBoxTraversee.DataSource = null;
                listBoxTraversee.DataSource = lTraversee;
                listBoxTraversee.DisplayMember = "DescriptionTraversee";

                tbCount.Text = ListeLiaisonParSecteur.Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        //ListBox Secteur

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;

            ListeLiaisonParSecteur = SicilyDAO.TrouverLiaison(secteur, lLiai);
            listBoxliaison.Visible = true;

            affiche();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Liaison liaison = listBoxliaison.SelectedItem as Liaison;

            lTraversee = SicilyDAO.TrouverTraversee(liaison, lTraver);
            listBoxTraversee.Visible = true;

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

        private void Supprimer_Click(object sender, EventArgs e)
        {
            Liaison liaison = listBoxliaison.SelectedItem as Liaison;

            if (liaison != null)
            {
                monManager.SupLiaison(liaison);
                lLiai = monManager.chargementLiaiBD();
                Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
                ListeLiaisonParSecteur = SicilyDAO.TrouverLiaison(secteur, lLiai);
                RefreshForm();
            }

        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Liaison liaison = (Liaison)listBoxliaison.SelectedItem;

            ModifDuree MD = new ModifDuree(liaison,monManager);
            MD.Owner = this;
            MD.ShowDialog();

            affiche();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int p = ((Secteur)listBoxSecteur.SelectedItem).Id;
            
                int idLiaison = Convert.ToInt32(tbLiaison.Text);
                int idSecteur = ((Secteur)listBoxSecteur.SelectedItem).Id;
                int idPortDepart = Convert.ToInt32(p);
                int idPortArrivee = Convert.ToInt32(tbArrivee.Text);
                string duree = tbDuree.Text;

                monManager.InsererNouvelleLiaison(idLiaison, idSecteur, idPortDepart, idPortArrivee, duree);

            lLiai = monManager.chargementLiaiBD();
            Secteur secteur = listBoxSecteur.SelectedItem as Secteur;
            ListeLiaisonParSecteur = SicilyDAO.TrouverLiaison(secteur, lLiai);

            // Rafraîchir la listBoxliaison avec la nouvelle liste
            RefreshForm();
            tbCount.Text = ListeLiaisonParSecteur.Count().ToString();

            tbArrivee.Clear();
            tbLiaison.Clear();
            tbDuree.Clear();
         

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}

