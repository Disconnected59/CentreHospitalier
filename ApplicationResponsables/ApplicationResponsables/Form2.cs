using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ApplicationResponsables
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ArrayList lesMois = new ArrayList(); // Liste des mois pour la comboBox
            String leMois = "Janvier";
            lesMois.Add(leMois);
            leMois = "Février";
            lesMois.Add(leMois);
            leMois = "Mars";
            lesMois.Add(leMois);
            leMois = "Avril";
            lesMois.Add(leMois);
            leMois = "Mai";
            lesMois.Add(leMois);
            leMois = "Juin";
            lesMois.Add(leMois);
            leMois = "Juillet";
            lesMois.Add(leMois);
            leMois = "Aout";
            lesMois.Add(leMois);
            leMois = "Septembre";
            lesMois.Add(leMois);
            leMois = "Octobre";
            lesMois.Add(leMois);
            leMois = "Novembre";
            lesMois.Add(leMois);
            leMois = "Decembre";
            lesMois.Add(leMois);
            cbboxMois.DataSource = lesMois;

            ArrayList lesServices = Passerelle.getServices();
            cbboxService.DataSource = lesServices;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbboxPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            /*String serviceChoisi = (String)cbboxService.SelectedItem;
            int moisChoisi = (int)cbboxMois.SelectedIndex + 1;

            Passerelle.getdureemoyenne(serviceChoisi, moisChoisi);
            lblduree.Text = "La durée moyenne est ";*/
        }

        private void lblduree_Click(object sender, EventArgs e)
        {

        }

       

        private void btnBascule2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void lblPeriode_Click(object sender, EventArgs e)
        {

        }
    }
}
