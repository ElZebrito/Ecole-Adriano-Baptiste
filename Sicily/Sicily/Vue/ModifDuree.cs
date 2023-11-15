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

        public ModifDuree(Liaison liaison)
        {
            InitializeComponent();

            this.liaison = liaison;
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
            liaison.Duree  = tbDuree.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
