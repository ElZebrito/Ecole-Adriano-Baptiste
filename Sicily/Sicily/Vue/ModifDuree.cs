using Sicily.Controleur;
using Sicily.DAL;
using Sicily.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sicily.Vue
{
    public partial class ModifDuree : Form
    {
        private Liaison liaison;
        private Mgr monManager;

        public ModifDuree(Liaison liaison, Mgr manager)
        {
            InitializeComponent();

            this.liaison = liaison;
            this.monManager = manager;
        }

        public ModifDuree()
        {
            InitializeComponent();

            
        }
        private void ModifDuree_Load(object sender, EventArgs e)
        {
            tbLiaison.Text = liaison.IdLiaison.ToString();
            tbSecteur.Text = liaison.IdSecteur.ToString();
            tbDepart.Text = liaison.IdPortDepart.ToString();
            tbArrivee.Text = liaison.IdPortArrivee.ToString();
            tbDuree.Text = liaison.Duree;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liaison.Duree = tbDuree.Text;

            
            monManager.ModifDurer(liaison, tbDuree.Text);
            (this.Owner as Form1)?.RefreshForm();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbLiaison_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
