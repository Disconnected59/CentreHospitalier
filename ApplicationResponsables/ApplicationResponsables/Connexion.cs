using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationResponsables
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {

        }

        private void btnValiderConnexion_Click(object sender, EventArgs e)
        {
            string id = txtBoxLabel.Text;
            string mdp = txtBoxMdp.Text;
            if (Passerelle.connexionIhm())
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
            }
        }
    }
}
