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
            ArrayList lesMois = new ArrayList(); // Liste des mois pour la listBox des mois de l'IHM  //Lecompte 18/09/2018
            ArrayList lesMois2 = new ArrayList();
            String leMois = "Janvier";
            lesMois.Add(leMois);
            lesMois2.Add(leMois);
            leMois = "Février";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Mars";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Avril";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Mai";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Juin";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Juillet";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Aout";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Septembre";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Octobre";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Novembre";
            lesMois2.Add(leMois);
            lesMois.Add(leMois);
            leMois = "Decembre";
            lesMois.Add(leMois);
            lesMois2.Add(leMois);

            cbbdebutperiode.DataSource = lesMois;
            cbbfinperiode.DataSource = lesMois2;

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
            ArrayList lesSejours = new ArrayList();
            int serviceChoisi = (int)cbboxService.SelectedIndex + 1;


            int moisDebut = (int)cbbdebutperiode.SelectedIndex + 1;
            int moisFin = (int)cbbfinperiode.SelectedIndex + 1;


            int capaMax = Passerelle.recupCapacitéMax(serviceChoisi);
            lesSejours = Passerelle.SejoursServiceParPeriode(moisDebut, moisFin, serviceChoisi);
            dureeMoyDiagramme T1 = new dureeMoyDiagramme(lesSejours, moisDebut, moisFin);
            T1.ShowDialog();
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
