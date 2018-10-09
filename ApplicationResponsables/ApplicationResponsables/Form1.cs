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

            cmbMois2.DataSource = lesMois;
            cmbMois3.DataSource = lesMois2;
            
        
            ArrayList lesServices = Passerelle.getServices();
            cmbServices.DataSource = lesServices;
            


           
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

     

        private void btnValidMoisService_Click(object sender, EventArgs e)
        { }

        private void cmbMois_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void btnValidPeriodeService_Click(object sender, EventArgs e)
        {
            ArrayList lesSejours = new ArrayList();
            int serviceChoisi = (int)cmbServices.SelectedIndex + 1;
           

            int moisDebut = (int)cmbMois2.SelectedIndex+1;
            int moisFin = (int)cmbMois3.SelectedIndex+1;


            int capaMax = Passerelle.recupCapacitéMax(serviceChoisi);
            lesSejours = Passerelle.SejoursServiceParPeriode(moisDebut, moisFin, serviceChoisi);

            TauxOccuPeriodeService T1 = new TauxOccuPeriodeService(capaMax, lesSejours, moisDebut, moisFin);
            T1.ShowDialog();

          




        }

        private void btnBascule1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btnValidMoisService_Click_1(object sender, EventArgs e)
        {/*
            String serviceChoisi = (String)cmbServices.SelectedItem;
            int moisChoisi = (int)cmbMois.SelectedIndex + 1;

            Passerelle.getTauxOccuMois(serviceChoisi, moisChoisi);*/

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMois3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
           


        

        }

       
       
      
    }

