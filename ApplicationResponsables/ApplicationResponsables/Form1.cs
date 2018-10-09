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
            int serviceChoisi = (int)cmbServices.SelectedIndex + 1;
            String intituService="";
            if(serviceChoisi == 1)
            {
                intituService = "Cardiologie";
            }
            else if(serviceChoisi==2)
            {
                intituService = "Psychiatrie";
            }
            else if(serviceChoisi==3)
            {
                intituService = "Chirurgie cardiaque";
            }
            else if(serviceChoisi==4)
            {
                intituService = "Reeducation";
            }
            String moisDebut = (String)cmbMois2.SelectedValue;
            String moisFin = (String)cmbMois3.SelectedValue;

            MessageBox.Show("Mois début : " + moisDebut + "\n Mois fin : " + moisFin);




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

        
           


        

        }

       
       
      
    }

