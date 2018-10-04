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

        private void btnValidMoisService_Click(object sender, EventArgs e)
        { }

        private void cmbMois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btnValidPeriodeService_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtDebutPeriode.Value;
            DateTime dateFin = dtFinPeriode.Value;
            int serviceChoisi = (int)cmbServices2.SelectedIndex + 1;
            String intituService="";
            if(serviceChoisi == 1)
            {
                intituService = "cardiologie";
            }
            else if(serviceChoisi==2)
            {
                intituService = "neurologie";
            }
            else if(serviceChoisi==3)
            {
                intituService = "pediatrie";
            }
            else if(serviceChoisi==4)
            {
                intituService = "chirurgie vasculaire";
            }
            else if(serviceChoisi==5)
            {
                intituService = "psychiatrie";
            }

            double taux = Passerelle.tauxOccupationPeriodeService(dateDebut, dateFin, serviceChoisi);
            if (taux == 0)
            {
                MessageBox.Show("Il n'y a eu personne durant cette période pour ce service, veuillez resélectionner");

            }
            else
            {
                TauxOccuPeriodeService t1 = new TauxOccuPeriodeService(taux,dateDebut,dateFin, intituService);
                t1.ShowDialog();
            }
            
            
        }

        private void btnBascule1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btnValidMoisService_Click_1(object sender, EventArgs e)
        {
            String serviceChoisi = (String)cmbServices.SelectedItem;
            int moisChoisi = (int)cmbMois.SelectedIndex + 1;

            Passerelle.getTauxOccuMois(serviceChoisi, moisChoisi);

        }

        
           


        

        }

       
       
      
    }

