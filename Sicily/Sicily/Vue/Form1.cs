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

namespace Sicily
{
    public partial class Form1 : Form
    {
        Mgr monManager;

        List<Secteur> lSec = new List<Secteur>();
        List<Liaison> lLiai= new List<Liaison>();
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
                listBoxliaison.DataSource = lLiai;
                listBoxliaison.DisplayMember = "DescriptionLiaison";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
