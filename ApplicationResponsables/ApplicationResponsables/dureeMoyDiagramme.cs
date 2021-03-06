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
    public partial class dureeMoyDiagramme : Form
    {
        public dureeMoyDiagramme(ArrayList pSejour, int pMoisDebut, int pMoisFin)
        {
            InitializeComponent();
            
            Sejour unSejour = (Sejour)pSejour[1];

           int serviceChoisi = unSejour.getIdService();
            String intituService = "";
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


            
            chartdureemoy.Titles["Title1"].Text = "Durée moyenne d'occupation du service : " + intituService + " de " + getIntituleMois(pMoisDebut) + " 2018 à " + getIntituleMois(pMoisFin) + " 2018";


            foreach (Sejour leSejour in pSejour )
             {
                
                 Double dureeMoyenne = leSejour.getDureeMoyenne();
                 String leMois = leSejour.getMoisSejour();
                 chartdureemoy.Series["Durée Moyenne"].Points.AddXY(leMois,dureeMoyenne);
                 
             }

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private static String getIntituleMois(int pMois)
        {
            String intitule;
            String[] lesMois = new String[12];
            lesMois[0] = "Janvier";
            lesMois[1] = "Février";
            lesMois[2] = "Mars";
            lesMois[3] = "Avril";
            lesMois[4] = "Mai";
            lesMois[5] = "Juin";
            lesMois[6] = "Juillet";
            lesMois[7] = "Aout";
            lesMois[8] = "Septembre";
            lesMois[9] = "Octobre";
            lesMois[10] = "Novembre";
            lesMois[11] = "Descembre";

            intitule = lesMois[pMois-1];
            return intitule;

        }
        
    }
}
