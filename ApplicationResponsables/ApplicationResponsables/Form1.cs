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
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            ArrayList lesMois = new ArrayList(); // Liste des mois pour la listBox des mois de l'IHM  //Lecompte 18/09/2018
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
            cmbMois.DataSource = lesMois;

            ArrayList lesPatients = Passerelle.getPatients();
            cmbPatients.DataSource = lesPatients;
            ArrayList lesServices = Passerelle.getServices();
            cmbServices.DataSource = lesServices;
            cmbServices2.DataSource = lesServices;


           
        }

        private void listMois_SelectedIndexChanged(object sender, EventArgs e) 
        {
           
           

        }

        private void lblDebut_Click(object sender, EventArgs e)
        {

        }

        private void dtpDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnValidChangerDebut_Click(object sender, EventArgs e)
        {
            DateTime dateDebutHospi = dtpDebut.Value;




        }
    }
}
