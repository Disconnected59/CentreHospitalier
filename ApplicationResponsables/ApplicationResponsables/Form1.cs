﻿using System;
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

        private void btnValidPeriodeService_Click(object sender, EventArgs e)
        {
            DateTime dateDebut = dtDebutPeriode.Value;
            DateTime dateFin = dtFinPeriode.Value;
            int serviceChoisi = (int)cmbServices2.SelectedIndex + 1;

            double taux = Passerelle.tauxOccupationPeriodeService(dateDebut, dateFin, serviceChoisi);

            String[] X = new String[] {taux+"", "Taux occuppé"};

            String[] y = new String[] {100-taux+"", "Taux restant"};

            
        }

        /*private void btnValidMoisService_Click(object sender, EventArgs e)
        {
            String serviceChoisi = (String)cmbServices.SelectedItem;
            int moisChoisi = (int)cmbMois.SelectedIndex+1;

            Passerelle.getTauxOccuMois(serviceChoisi, moisChoisi);



        }*/

        }

       
       
      
    }

